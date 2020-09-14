﻿using System;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing;

namespace Spectre
{
    public partial class Main : Form
    {
        private int ampMax, ampMin, dispMax, dispMin, amount;
        private double noisePercent, filterPercent;
        private int picHeight, picWidth, spectreHeight, spectreWidth;

        private double amp, dispX, dispY;
        private int centerX, centerY;

        private double[,] picture, noise, noisedPicture, interpolatePicture;
        //private double[] interLineBefore, interColumnBefore, interLineAfter, interColumnAfter;

        Complex[,] spectre, spectreToDraw, complexPic;
        Complex[] line, column;

        Complex buf;

        Random rand;

        public Main()
        {
            InitializeComponent();

            rand = new Random();
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            // суем значения
            ampMax = Convert.ToInt32(txtAmpMax.Text);
            ampMin = Convert.ToInt32(txtAmpMin.Text);
            dispMax = Convert.ToInt32(txtDispMax.Text);
            dispMin = Convert.ToInt32(txtDispMin.Text);

            amount = Convert.ToInt32(txtDomeAmount.Text);
            picHeight = Convert.ToInt32(txtHeight.Text);
            picWidth = Convert.ToInt32(txtWidth.Text);

            noisePercent = Convert.ToDouble(txtNoisePercent.Text) / 100;

            // выделяем место
            picture = new double[picWidth, picHeight];
            noise = new double[picWidth, picHeight];
            noisedPicture = new double[picWidth, picHeight];

            for(int k = 0; k < amount; k++)
            {
                amp = GetRandom(ampMin, ampMax);
                dispX = GetRandom(dispMin, dispMax);
                dispY = GetRandom(dispMin, dispMax);
                centerX = (int)(rand.NextDouble() * picWidth);
                centerY = (int)(rand.NextDouble() * picHeight);

                for (int i = 0; i < picWidth; i++)
                {
                    for (int j = 0; j < picHeight; j++)
                    {
                        picture[i, j] += GaussDome(amp, dispX, centerX, dispY, centerY, i, j);
                    }
                }
            }

            // создание шума
            double temp;
            for (int i = 0; i < picWidth; i++)
            {
                for (int j = 0; j < picHeight; j++)
                {
                    temp = 0;
                    for (int k = 0; k < 12; k++)
                    {
                        temp += rand.NextDouble() / 12;
                    }   
                    noise[i, j] = temp;
                }
            }

            noise = GetRealNoise(picture, noise, picHeight, picWidth, noisePercent);
            for (int i = 0; i < picWidth; i++)
            {
                for (int j = 0; j < picHeight; j++)
                {
                    noisedPicture[i, j] = picture[i, j] + noise[i, j];
                }
            }

            interpolatePicture = noisedPicture;

            // является ли ширина картинки степенью двойки?
            if (!IsPowerOfTwo(picWidth))
            {
                spectreWidth = PowerOfTwo(picWidth); // если нет, то находим ближайшую превосходящую степень
            }
            else
            {
                spectreWidth = picWidth; // если да, то просто даем спектру такое же значение
                //interpolatePicture = noisedPicture;
            }

            // является ли высота картинки степенью двойки?
            if (!IsPowerOfTwo(picHeight))
            {
                spectreHeight = PowerOfTwo(picHeight); // если нет, то находим ближайшую превосходящую степень
            }
            else
            {
                spectreHeight = picHeight; // если да, то просто даем спектру такое же значение
            }

            // проводим интерполяцию
            interpolatePicture = InterpolateMatrix(noisedPicture, spectreWidth, spectreHeight);

            DrawMatrix(pcbInitial, interpolatePicture, spectreHeight, spectreWidth);

            labelWidth.Text = interpolatePicture.GetLength(0).ToString();
            labelHeight.Text = interpolatePicture.GetLength(1).ToString();

            btnCreateSpectre.Enabled = true;
        }

        private void btnCreateSpectre_Click(object sender, EventArgs e)
        {
            Complex buffer;

            complexPic = new Complex[spectreWidth, spectreHeight];
            spectre = new Complex[spectreWidth, spectreHeight];
            spectreToDraw = new Complex[spectreWidth, spectreHeight];

            line = new Complex[spectreWidth];
            column = new Complex[spectreHeight];

            for (int i = 0; i < spectreWidth; i++)
            {
                for (int j = 0; j < spectreHeight; j++)
                {
                    buffer = new Complex(interpolatePicture[i, j], 0);
                    spectre[i, j] = complexPic[i, j] = buffer;
                }
            }

            // итерация по строкам матрицы
            for (int i = 0; i < spectreHeight; i++)
            {
                for (int j = 0; j < spectreWidth; j++)
                {
                    line[j] = spectre[j, i];
                }

                line = Fourea(line, spectreWidth, -1);

                for (int j = 0; j < spectreWidth; j++)
                {
                    spectre[j, i] = line[j];
                }
            }

            // итерация по столбцам матрицы
            for (int j = 0; j < spectreWidth; j++)
            {
                for (int i = 0; i < spectreHeight; i++)
                {
                    column[i] = spectre[j, i];
                }

                column = Fourea(column, spectreHeight, -1);

                for (int i = 0; i < spectreHeight; i++)
                {
                    spectre[j, i] = column[i];
                }
            }

            spectre[0, 0] = 0;

            for (int i = 0; i < spectre.GetLength(0); i++)
            {
                for (int j = 0; j < spectre.GetLength(1); j++)
                {
                    spectreToDraw[i, j] = spectre[i, j];
                }
            }

            DrawMatrix(pcbSpectre, ConvertToDraw(spectreToDraw, spectreHeight, spectreWidth), spectreHeight, spectreWidth);

            btnFilter.Enabled = true;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterPercent = Convert.ToDouble(txtFilterPercent.Text) / 100;

            // подсчет энергии спектра
            double energySpectreFull = 0;

            for (int i = 0; i < spectre.GetLength(0); i++)
            {
                for (int j = 0; j < spectre.GetLength(1); j++)
                {
                    energySpectreFull += Math.Pow(spectre[i, j].Magnitude, 2);
                }
            }

            double energy = 0;
            int radiusLast = (int)(spectreHeight / 2 * 1.4);

            for (int radius = 1; radius < spectreHeight / 2; radius++)
            {
                for (int i = 0; i < spectreWidth / 2; i++)
                {
                    for (int j = 0; j < spectreHeight / 2; j++)
                    {
                        if (Math.Sqrt(i * i + j * j) <= radius)
                        {
                            energy += Math.Pow(spectre[j, i].Magnitude, 2);
                            energy += Math.Pow(spectre[spectreHeight - 1 - j, i].Magnitude, 2);
                            energy += Math.Pow(spectre[spectreHeight - 1 - j, spectreWidth - 1 - i].Magnitude, 2);
                            energy += Math.Pow(spectre[j, spectreWidth - 1 - i].Magnitude, 2);
                        }
                    }
                }

                if(energy < energySpectreFull * filterPercent)
                {
                    energy = 0;
                }
                else
                {
                    radiusLast = radius;
                    break;
                }
            }

            for (int i = 0; i < spectreWidth / 2; i++)
            {
                for (int j = 0; j < spectreHeight / 2; j++)
                {
                    if (Math.Sqrt(i * i + j * j) > radiusLast)
                    {
                        buf = new Complex(0, 0);
                        spectre[i, j] = buf;
                        spectre[spectreWidth - 1 - i, j] = buf;
                        spectre[spectreWidth - 1 - i, spectreHeight - 1 - j] = buf;
                        spectre[i, spectreHeight - 1 - j] = buf;
                    }
                }
            }

            DrawMatrix(pcbSpectre, ConvertToDraw(spectre, spectreHeight, spectreWidth), spectreHeight, spectreWidth);

            // итерация по строкам матрицы
            for (int i = 0; i < spectreHeight; i++)
            {
                for (int j = 0; j < spectreWidth; j++)
                {
                    line[j] = spectre[j, i];
                }

                line = Fourea(line, spectreWidth, 1);

                for (int j = 0; j < spectreWidth; j++)
                {
                    spectre[j, i] = line[j];
                }
            }

            // итерация по столбцам матрицы
            for (int j = 0; j < spectreWidth; j++)
            {
                for (int i = 0; i < spectreHeight; i++)
                {
                    column[i] = spectre[j, i];
                }

                column = Fourea(column, spectreHeight, 1);

                for (int i = 0; i < spectreHeight; i++)
                {
                    spectre[j, i] = column[i];
                }
            }

            DrawMatrix(pcbFilter, ConvertToDraw(spectre, spectreHeight, spectreWidth), spectreHeight, spectreWidth);
        }

        double[,] ConvertToDraw(Complex[,] arr, int height, int width)
        {
            double[,] result = new double[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    result[i, j] = Math.Sqrt(Math.Sqrt(Math.Sqrt(Math.Pow(Math.Sqrt(arr[i, j].Magnitude), 5))));
                }   
            }
                
            return result;
        }

        double[,] GetRealNoise(double[,] arr, double[,] noise, int height, int width, double percent)
        {
            double d;
            double energy = 0;
            double sum = 0;
            double n_energy = 0;
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    sum = arr[i, j] * arr[i, j];
                    energy += arr[i, j] * arr[i, j];
                    n_energy += noise[i, j] * noise[i, j];
                }
            d = energy / n_energy * percent;
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    noise[i, j] *= Math.Sqrt(d);
            return noise;
        }

        public void DrawMatrix(PictureBox pcb, double[,] drawArray, int height, int width)
        {
            Color clr;
            Bitmap bmp = new Bitmap(width, height);
            drawArray = Flat(height, width, drawArray);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    clr = Color.FromArgb(
                        (int)(drawArray[i, j] * 255),
                        (int)(drawArray[i, j] * 255),
                        (int)(drawArray[i, j] * 255));
                    bmp.SetPixel(i, j, clr);
                }
            }
            //img1 = bmp;
            pcb.Image = bmp;
        }

        double[,] Flat(int height, int width, double[,] to_flat)
        {
            double[,] flatten = new double[width, height];
            double max = 0;

            // поиск максимального элемента матрицы
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (to_flat[i, j] > max) max = to_flat[i, j];
                }
            }

            // нормировка на максимальный элемент
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    flatten[i, j] = to_flat[i, j] / max;
                }
            }

            return flatten;
        }

        private double GaussDome(double amp, double dispX, double centerX, double dispY, double centerY, int i, int j)
        {
            return amp * Math.Exp(-Math.Pow(i - centerX, 2) / 2 / dispX / dispX - Math.Pow(j - centerY, 2) / 2 / dispY / dispY);
        }

        /// <summary>
        /// Растягивает матрицу до указанных значений ширины/высоты.
        /// </summary>
        /// <param name="source">Исходная матрица.</param>
        /// <param name="requiredWidth">Необходимая ширина.</param>
        /// <param name="requiredHeight">Необходимая высота.</param>
        /// <returns>Растянутая до указанных значений матрица.</returns>
        private double[,] InterpolateMatrix(double[,] source, int requiredWidth, int requiredHeight)
        {
            double[,] result = new double[requiredWidth, requiredHeight];

            // итерация по строкам матрицы
            double[] bufferBefore = new double[source.GetLength(0)];
            double[] bufferAfter = new double[requiredWidth];

            for (int i = 0; i < source.GetLength(1); i++)
            {
                for (int j = 0; j < source.GetLength(0); j++)
                {
                    bufferBefore[j] = source[j, i];
                }

                bufferAfter = InterpolateArray(bufferBefore, requiredWidth);

                for (int j = 0; j < requiredWidth; j++)
                {
                    result[j, i] = bufferAfter[j];
                }
            }

            // итерация по столбцам матрицы
            bufferBefore = new double[source.GetLength(1)];
            bufferAfter = new double[requiredHeight];

            for (int i = 0; i < requiredWidth; i++)
            {
                for (int j = 0; j < source.GetLength(1); j++)
                {
                    bufferBefore[j] = result[i, j];
                }

                bufferAfter = InterpolateArray(bufferBefore, requiredHeight);

                for (int j = 0; j < requiredHeight; j++)
                {
                    result[i, j] = bufferAfter[j];
                }
            }
            
            return result;
        }

        /// <summary>
        /// Возвращает случайное число в диапазоне.
        /// </summary>
        /// <param name="minimum">Левая граница диапазона.</param>
        /// <param name="maximum">Правая граница диапазона.</param>
        /// <returns>Случайное число из диапазона.</returns>
        public double GetRandom(double minimum, double maximum)
        {
            //return rand.NextDouble() * (maximum - minimum);
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }

        /// <summary>
        /// Проверяет, является ли число степенью двойки.
        /// </summary>
        /// <param name="digit">Число для проверки.</param>
        /// <returns>true, если является, false, если не является.</returns>
        public bool IsPowerOfTwo(int digit)
        {
            return digit != 0 && (digit & (digit - 1)) == 0;
        }

        /// <summary>
        /// Возвращает ближайшее число, являющееся степенью двойки, и превосходящее данное число.
        /// </summary>
        /// <param name="digit">Число, для которого требуется найти превосходящую степень двойки.</param>
        /// <returns>Число, являющееся спепенью двойки,  превосходящее данное.</returns>
        public int PowerOfTwo(int digit)
        {
            return (int)Math.Pow(2, Math.Ceiling(Math.Log(digit, 2)));
        }

        /// <summary>
        /// Растягивает массив данных.
        /// </summary>
        /// <param name="source">Исходный массив.</param>
        /// <param name="requiredLength">Требуемая длина нового массива.</param>
        /// <returns>Интерполированный массив.</returns>
        private double[] InterpolateArray(double[] source, int requiredLength)
        {
            int m = source.Length;
            double[] destination = new double[requiredLength];

            destination[0] = source[0];
            destination[requiredLength - 1] = source[source.Length - 1];

            for (int i = 1; i < requiredLength - 1; i++)
            {
                double jd = ((double)i * (double)(source.Length - 1) / (double)(requiredLength - 1));
                int j = (int)jd;
                destination[i] = source[j] + (source[j + 1] - source[j]) * (jd - (double)j);
            }
            return destination;
        }

        private Complex[] Fourea(Complex[] spectr, int n, int direct)
        {
            Complex buf;
            int i, j, istep;
            int m, mmax;
            double r, r1, theta, w_r, w_i, temp_r, temp_i;
            double pi = 3.1415926f;

            r = pi * direct;
            j = 0;
            for (i = 0; i < n; i++)
            {
                if (i < j)
                {
                    temp_r = spectr[j].Real;
                    temp_i = spectr[j].Imaginary;
                    buf = new Complex(spectr[i].Real, spectr[i].Imaginary);
                    spectr[j] = buf;
                    buf = new Complex(temp_r, temp_i);
                    spectr[i] = buf;
                }
                m = n >> 1;
                while (j >= m) { j -= m; m = (m + 1) / 2; }
                j += m;
            }

            mmax = 1;
            while (mmax < n)
            {
                istep = mmax << 1;
                r1 = r / (float)mmax;
                for (m = 0; m < mmax; m++)
                {
                    theta = r1 * m;
                    w_r = (float)Math.Cos((double)theta);
                    w_i = (float)Math.Sin((double)theta);
                    for (i = m; i < n; i += istep)
                    {
                        j = i + mmax;
                        temp_r = w_r * spectr[j].Real - w_i * spectr[j].Imaginary;
                        temp_i = w_r * spectr[j].Imaginary + w_i * spectr[j].Real;
                        buf = new Complex(spectr[i].Real - temp_r, spectr[i].Imaginary - temp_i);
                        spectr[j] = buf;
                        buf = new Complex(spectr[i].Real + temp_r, spectr[i].Imaginary + temp_i);
                        spectr[i] = buf;
                    }
                }
                mmax = istep;
            }

            if (direct > 0)
            {
                for (i = 0; i < n; i++)
                {
                    buf = new Complex(spectr[i].Real / (float)n, spectr[i].Imaginary / (float)n);
                    spectr[i] = buf;
                }
            }

            return spectr;
        }
    }
}
