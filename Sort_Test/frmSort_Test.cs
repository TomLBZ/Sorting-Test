using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sort_Test
{
    public partial class frmSort_Test : Form
    {
        public frmSort_Test()
        {
            InitializeComponent();
        }
        private int[] myData;
        private List<int[]> mySteps = new List<int[]>(0);
        private int lastX = 0, lastY = 0, picL = 0, picT = 0;
        private Bitmap bitmap = new Bitmap(610,539);
        private void frmSort_Test_Load(object sender, EventArgs e)
        {
            comboMethod.SelectedIndex = 2;
            btnStart.Enabled = false;
            txtManual.Enabled = false;
            picVisual.Image = bitmap;
        }
        private void btnInitialize_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(picVisual.DisplayRectangle.Width, picVisual.DisplayRectangle.Height);
            picVisual.Image = bitmap;
            mySteps = new List<int[]>(0);
            txtResult.Text = "";
            if (radBtnAuto.Checked)
            {
                int size = Convert.ToInt32(txtSize.Text);
                int step = size / 100;
                pBar1.Maximum = size;
                pBar1.Step = step;
                int[] intData = new int[size];
                long seed = DateTime.Now.Ticks;
                Random myRandom = new Random((int)seed);
                string strnum = "";
                for (int i = 0; i < size; i++)
                {
                    intData[i] = myRandom.Next(0, size);
                    strnum += intData[i].ToString() + ", ";
                    if (i % step == 0)
                    {
                        pBar1.PerformStep();
                        Application.DoEvents();
                    }
                }
                txtData.Text = strnum.Replace(", ", "\r\n");
                myData = intData;
                btnStart.Enabled = true;
                pBar1.Value = 0;
            }
            else
            {
                string[] splitted = txtManual.Text.Split(',');
                int size = splitted.Length;
                int step = size / 100;
                if(step == 0) { step = 1; }
                int[] data = new int[size];
                pBar1.Maximum = size;
                pBar1.Step = step;
                for (int i = 0; i < splitted.Length; i++)
                {
                    data[i] = Convert.ToInt32(splitted[i]);
                    if (i % step == 0)
                    {
                        pBar1.PerformStep();
                        Application.DoEvents();
                    }
                }
                txtData.Text = txtManual.Text.Replace(",", "\r\n");
                myData = data;
                btnStart.Enabled = true;
                pBar1.Value = 0;
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnInitialize_Click(sender, e);
            int[] result = myData;
            TimeSpan ts1 = Process.GetCurrentProcess().TotalProcessorTime;
            Stopwatch stw = new Stopwatch();
            stw.Start();
            switch (comboMethod.SelectedIndex)
            {
                case 0:
                    BubbleSort(ref result);
                    break;
                case 1:
                    insertionSort(ref result);
                    break;
                case 2:
                    QSort(ref result, 0, myData.Length - 1);
                        break;
                case 3:
                    selectionSort(ref result);
                    break;
                case 4:
                    MergeSortFunction(ref result, 0, myData.Length - 1);
                    break;
                default:
                    break;
            }
            double Msecs = Process.GetCurrentProcess().TotalProcessorTime.Subtract(ts1).TotalMilliseconds;
            stw.Stop();
            Present(result);
            lblTime.Text=string.Format("CPU used {0}ms \r\nProgram used {1}ms", Msecs, stw.Elapsed.TotalMilliseconds, stw.ElapsedTicks);
            if (chkTrace.Checked) { Trace(mySteps); }
            btnInitialize.Enabled = true;
        }
        private void Present(int[] results)
        {
            string strdata = "";
            int len = results.Length;
            int step = len / 100;
            pBar1.Maximum = len;
            pBar1.Step = step;
            if(step == 0) { step = 1; }
            for (int i = 0; i < len; i++)
            {
                strdata += results[i].ToString() + ", ";
                if (i % step == 0)
                {
                    pBar1.PerformStep();
                    Application.DoEvents();
                }
            }
            txtResult.Text = strdata.Replace(", ", "\r\n");
            pBar1.Value = 0;
        }
        private void Trace(List<int[]> steps)
        {
            int numbersize = Font.Height + 2;
            int textoffset = 1;
            int width = txtData.Text.Replace("\r\n","").Length * numbersize;
            int height = steps.Count() * numbersize;
            Bitmap bmp = new Bitmap(width, height);
            Graphics gra = Graphics.FromImage(bmp);
            int[] oldstep = new int[0];
            for (int i = 0; i < steps.Count(); i++)
            {
                int[] newstep = steps[i];
                bool comparable = oldstep.Length == newstep.Length;
                int headloc = 0;
                for (int j = 0; j < newstep.Length; j++)
                {
                    Brush sb = comparable && oldstep[j] != newstep[j] ? Brushes.Red : Brushes.Black;
                    string str = steps[i][j].ToString();
                    int w = str.Length * numbersize;
                    Rectangle rect = new Rectangle(headloc, i * numbersize, w, numbersize);
                    Rectangle txtRect = new Rectangle(headloc + textoffset, rect.Y + textoffset, w - textoffset, numbersize - textoffset);
                    headloc += w;
                    gra.FillEllipse(sb, rect);
                    gra.DrawString(ToFull(steps[i][j].ToString()), Font, Brushes.White, txtRect);
                }
                oldstep = newstep;
            }
            bitmap = new Bitmap(bmp);
            Rectangle rectangle = picVisual.DisplayRectangle;
            Graphics g = Graphics.FromImage(picVisual.Image);
            Text = string.Format("Sort Test - Viewing: picture pos({0}, {1}).", picL, picT);
            g.DrawImage(bitmap, rectangle, -picL, -picT, rectangle.Width, rectangle.Height, GraphicsUnit.Pixel);
            gra.Dispose();
            bmp.Dispose();
            picVisual.Refresh();
        }
        private string ToFull(string half)
        {
            char[] halfstr = half.ToCharArray();
            List<char> lst = new List<char>(0);
            for (int i = 0; i < halfstr.Length; i++)
            {
                lst.Add(' ');
                lst.Add(halfstr[i]);
                lst.Add(' ');
            }
            return new string(lst.ToArray());
        }
        private void QSort(ref int[] array,int left, int right)
        {
            if (right<=left)
            {
                return;
            }
            if (chkTrace.Checked) 
            {
                int[] arr = new int[array.Length];
                array.CopyTo(arr, 0);
                mySteps.Add(arr); 
            }
            int pivot = QsortUnitStep(ref array, left, right);
            QSort(ref array, left, pivot - 1);
            QSort(ref array, pivot + 1, right);
        }
        private static int QsortUnitStep(ref int[] array, int low, int high)
        {
            int key = array[low];
            while (low < high)
            {
                while (array[high] >= key && high > low)
                    --high;
                array[low] = array[high];
                while (array[low] <= key && high > low)
                    ++low;
                array[high] = array[low];
            }
            array[low] = key;
            return high;
        }
        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }
        public void BubbleSort(ref int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }
            int count = array.Length;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        if (chkTrace.Checked)
                        {
                            int[] arr = new int[array.Length];
                            array.CopyTo(arr, 0);
                            mySteps.Add(arr);
                        }
                    }
                }
            }
        }
        public void selectionSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        if (chkTrace.Checked)
                        {
                            int[] arr = new int[array.Length];
                            array.CopyTo(arr, 0);
                            mySteps.Add(arr);
                        }
                    }
                }
            }
        }
        public void insertionSort(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        if (chkTrace.Checked)
                        {
                            int[] arr = new int[array.Length];
                            array.CopyTo(arr, 0);
                            mySteps.Add(arr);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        private void MergeSortFunction(ref int[] array, int first, int last)
        {
            try
            {
                if (first < last)   
                {
                    int mid = (first + last) / 2; 
                    MergeSortFunction(ref array, first, mid); 
                    MergeSortFunction(ref array, mid + 1, last);  
                    Merge(ref array, first, mid, last);
                    if (chkTrace.Checked)
                    {
                        int[] arr = new int[array.Length];
                        array.CopyTo(arr, 0);
                        mySteps.Add(arr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", 0, MessageBoxIcon.Error);
            }
        }
        private static void Merge(ref int[] array, int first, int mid, int last)
        {
            try
            {
                int indexA = first;
                int indexB = mid + 1; 
                int[] temp = new int[last + 1];
                int tempIndex = 0;
                while (indexA <= mid && indexB <= last) 
                {
                    if (array[indexA] <= array[indexB]) 
                    {
                        temp[tempIndex++] = array[indexA++]; 
                    }
                    else
                    {
                        temp[tempIndex++] = array[indexB++]; 
                    }
                }
                while (indexA <= mid)
                {
                    temp[tempIndex++] = array[indexA++];
                }
                while (indexB <= last)
                {
                    temp[tempIndex++] = array[indexB++];
                }
                tempIndex = 0;
                for (int i = first; i <= last; i++)
                {
                    array[i] = temp[tempIndex++];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", 0, MessageBoxIcon.Error);
            }
        }
        private void radBtnManual_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnManual.Checked)
            {
                txtManual.Enabled = true;
            }
            else
            {
                txtManual.Enabled = false;
            }
        }
        private void frmSort_Test_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                picVisual.Width = ClientSize.Width - gBoxMain.Width;
            }
        }
        private void picVisual_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - lastX;
                int dy = e.Y - lastY;
                Rectangle rectangle = picVisual.DisplayRectangle;
                Bitmap img = new Bitmap(rectangle.Width, rectangle.Height);
                Graphics g = Graphics.FromImage(img);
                picL += dx;
                picT += dy;
                lastX = e.X;
                lastY = e.Y;
                g.DrawImage(bitmap, rectangle, -picL, -picT, rectangle.Width, rectangle.Height, GraphicsUnit.Pixel);
                picVisual.Image = img;
                picVisual.Refresh();
                img.Dispose();
                g.Dispose();
            }
            Text = string.Format("Sort Test - Viewing: picture pos({0}, {1}), mouse pos({2},{3}).", picL, picT, e.X, e.Y);
        }
        private void picVisual_MouseDown(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
            Text = string.Format("Sort Test - Viewing: picture pos({0}, {1}), mouse pos({2},{3}).", picL, picT, e.X, e.Y);
        }
    }
}
