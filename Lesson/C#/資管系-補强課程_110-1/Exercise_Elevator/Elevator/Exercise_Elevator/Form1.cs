using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Elevator
{
    public partial class Form1 : Form
    {
        char state = 'U';
        short x;
        bool[] Inside = new bool[7];
        char[] Outside = new char[7];        

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inside[1] = false;
            Inside[2] = false;
            Inside[3] = false;
            Inside[4] = false;
            Inside[5] = false;
            Inside[6] = false;

            Outside[1] = '4';
            Outside[2] = '4';
            Outside[3] = '4';
            Outside[4] = '4';
            Outside[5] = '4';
            Outside[6] = '4';
        }

        private void INCheckedChanged(object sender, EventArgs e)
        {
            CheckBox CB = (CheckBox)sender;
            if(CB.Checked == true)
            {
                short floor = short.Parse(CB.Name.ToString().Substring(1, 1));
                Inside[floor] = true;
            }
            else
            {
                short floor = short.Parse(CB.Name.ToString().Substring(1, 1));
                Inside[floor] = false;               
            }
        }

        private void OUTCheckedChanged(object sender, EventArgs e)
        {
            short temp = 0;
            short floor = short.Parse(OF1.Name.ToString().Substring(2, 1));

            foreach (Control ctrl in OF1.Controls)
            {
                if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "U")
                {
                    temp++;
                }
                else if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "D")
                {
                    temp += 5;
                }
            }

            switch(temp)
            {
                case 0:
                    Outside[floor] = '4';
                    break;

                case 1:
                    Outside[floor] = '1';
                    break;

                case 5:
                    Outside[floor] = '2';
                    break;

                case 6:
                    Outside[floor] = '3';
                    break;
            }
        }

        private void OUTCheckedChanged2(object sender, EventArgs e)
        {
            short temp = 0;
            short floor = short.Parse(OF2.Name.ToString().Substring(2, 1));

            foreach (Control ctrl in OF2.Controls)
            {
                if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "U")
                {
                    temp++;
                }
                else if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "D")
                {
                    temp += 5;
                }
            }

            switch (temp)
            {
                case 0:
                    Outside[floor] = '4';
                    break;

                case 1:
                    Outside[floor] = '1';
                    break;

                case 5:
                    Outside[floor] = '2';
                    break;

                case 6:
                    Outside[floor] = '3';
                    break;
            }
        }

        private void OUTCheckedChanged3(object sender, EventArgs e)
        {
            short temp = 0;
            short floor = short.Parse(OF3.Name.ToString().Substring(2, 1));

            foreach (Control ctrl in OF3.Controls)
            {
                if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "U")
                {
                    temp++;
                }
                else if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "D")
                {
                    temp += 5;
                }
            }

            switch (temp)
            {
                case 0:
                    Outside[floor] = '4';
                    break;

                case 1:
                    Outside[floor] = '1';
                    break;

                case 5:
                    Outside[floor] = '2';
                    break;

                case 6:
                    Outside[floor] = '3';
                    break;
            }
        }

        private void OUTCheckedChanged4(object sender, EventArgs e)
        {
            short temp = 0;
            short floor = short.Parse(OF4.Name.ToString().Substring(2, 1));

            foreach (Control ctrl in OF4.Controls)
            {
                if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "U")
                {
                    temp++;
                }
                else if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "D")
                {
                    temp += 5;
                }
            }

            switch (temp)
            {
                case 0:
                    Outside[floor] = '4';
                    break;

                case 1:
                    Outside[floor] = '1';
                    break;

                case 5:
                    Outside[floor] = '2';
                    break;

                case 6:
                    Outside[floor] = '3';
                    break;
            }           
        }

        private void OUTCheckedChanged5(object sender, EventArgs e)
        {
            short temp = 0;
            short floor = short.Parse(OF5.Name.ToString().Substring(2, 1));

            foreach (Control ctrl in OF5.Controls)
            {
                if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "U")
                {
                    temp++;
                }
                else if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "D")
                {
                    temp += 5;
                }
            }

            switch (temp)
            {
                case 0:
                    Outside[floor] = '4';
                    break;

                case 1:
                    Outside[floor] = '1';
                    break;

                case 5:
                    Outside[floor] = '2';
                    break;

                case 6:
                    Outside[floor] = '3';
                    break;
            }
        }

        private void OUTCheckedChanged6(object sender, EventArgs e)
        {
            short temp = 0;
            short floor = short.Parse(OF6.Name.ToString().Substring(2, 1));

            foreach (Control ctrl in OF6.Controls)
            {
                if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "U")
                {
                    temp++;
                }
                else if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked && ctrl.Name.ToString().Substring(0, 1) == "D")
                {
                    temp += 5;
                }
            }

            switch (temp)
            {
                case 0:
                    Outside[floor] = '4';
                    break;

                case 1:
                    Outside[floor] = '1';
                    break;

                case 5:
                    Outside[floor] = '2';
                    break;

                case 6:
                    Outside[floor] = '3';
                    break;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            x = short.Parse(display.Text);
            int temp = x;

            FClose.Checked = true;
            Start.Enabled = false;

            Thread.Sleep(500);

            for (short i = 1; i <= 6; i++)
            {
                if (state == 'U')
                {
                    temp++;
                    if (temp > 6)
                    {
                        if (Outside[temp-1] == '2')
                        {
                            state = 'D';
                            ChangeState();                         
                        }
                        temp = temp - 6;
                    }

                    if (temp > x)
                    {
                        if (Inside[temp] == true)
                        {
                            x++;
                            break;
                        }
                        else if (Outside[temp] == '1' || Outside[temp] == '2' || Outside[temp] == '3')
                        {
                            x++;
                            break;
                        }
                        
                    }                   
                    else if(temp < x)
                    {
                        if(Inside[temp] == true)
                        {
                            x--;
                            state = 'D';
                            break;
                        }
                        else if(Outside[temp] == '1' || Outside[temp] == '2' || Outside[temp] == '3')
                        {
                            x--;
                            state = 'D';
                            break;
                        }
                    }                    
                }
                else if (state == 'D')
                {
                    temp--;
                    if (temp < 1) temp = temp + 6;

                    if (temp < x)
                    {
                        if(Inside[temp] == true)
                        {
                            x--;
                            break;
                        }
                        else if (Outside[temp] == '1' || Outside[temp] == '2' || Outside[temp] == '3')
                        {
                            x--;
                            break;
                        }
                    }
                    else if (temp == x && Outside[x] == '1')
                    {
                        ChangeState();
                        state = 'U';
                    }
                    else if (temp > x)
                    {
                        if(Inside[temp] == true)
                        {
                            x++;
                            state = 'U';
                            break;
                        }
                        else if(Outside[temp] == '1' || Outside[temp] == '2' || Outside[temp] == '3')
                        {
                            x++;
                            state = 'U';
                            break;
                        }
                    }                    
                }               
            }

            display.Text = x.ToString();

            ChangeState();

            Start.Enabled = true;
        }

        private void ChangeState()
        {
            if (Inside[x] == true)
            {
                switch (x)
                {
                    case 1:
                        G1.Checked = false;
                        U1.Checked = false;
                        break;
                    case 2:
                        G2.Checked = false;
                        break;
                    case 3:
                        G3.Checked = false;
                        break;
                    case 4:
                        G4.Checked = false;
                        break;
                    case 5:
                        G5.Checked = false;
                        break;
                    case 6:
                        G6.Checked = false;
                        D6.Checked = false;
                        break;
                }

                Open.Checked = true;
            }
            if (state == 'U')
            {
                if (Outside[x] == '1' || Outside[x] == '3')
                {
                    switch (x)
                    {
                        case 1:
                            U1.Checked = false;
                            break;
                        case 2:
                            U2.Checked = false;
                            break;
                        case 3:
                            U3.Checked = false;
                            break;
                        case 4:
                            U4.Checked = false;
                            break;
                        case 5:
                            U5.Checked = false;
                            break;
                    }
                    Open.Checked = true;
                }
            }
            if (state == 'D')
            {
                if (Outside[x] == '2' || Outside[x] == '3')
                {
                    switch (x)
                    {
                        case 2:
                            D2.Checked = false;
                            break;
                        case 3:
                            D3.Checked = false;
                            break;
                        case 4:
                            D4.Checked = false;
                            break;
                        case 5:
                            D5.Checked = false;
                            break;
                        case 6:
                            D6.Checked = false;
                            break;
                    }
                    Open.Checked = true;
                }
            }
        }
    }
}
