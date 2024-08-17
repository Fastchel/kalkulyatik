using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Flee;
using Flee.CalcEngine.PublicTypes;
using Flee.PublicTypes;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button2_Click(object sender, EventArgs e)//Сворачивание
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int detect = 1;
             
        private void textBox1_TextChanged(object sender, EventArgs e) // изменение текста
        {
            if (this.textBox1.Text.Length > 10)
            { this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            }
                       
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {                       
        }
        bool point = true;
        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (point && Convert.ToInt32(this.textBox1.Text[this.textBox1.Text.Length - 1])>47 && Convert.ToInt32(this.textBox1.Text[this.textBox1.Text.Length-1])<58)
            {
                this.textBox1.Text += ',';
                point = false;
            }            
        }
        bool chek = false;
        
        private void roundButton14_Click(object sender, EventArgs e)// =
        {
            CalculationEngine engine = new CalculationEngine();
            ExpressionContext context = new ExpressionContext();
            VariableCollection variables = context.Variables;
            if (math && Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text) || this.textBox1.Text.Contains("-") && Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
            {
                
                
                try
                {
                    this.textBox2.Visible = true;
                    this.textBox2.Text += this.textBox1.Text;
                    engine.Add("a", this.textBox2.Text.Replace('×', '*').Replace('÷', '/').ToString(), context);

                    
                        try { this.textBox1.Text = " " + engine.GetResult<double>("a").ToString(); } catch { try { this.textBox1.Text = " " + engine.GetResult<int>("a").ToString(); } catch { } }
                        math = false;
                        chek = true;
                        this.textBox2.Text = this.textBox2.Text.Replace("  ", " ");
                    
                }
                catch {
                    this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.textBox1.Text = " 0";
                    this.textBox2.Visible = false;
                    this.textBox2.Text = "";                  
                    point = true;
                    skobki = true;
                    math = false;
                }
            }
            else if (!skobki) { this.textBox3.Visible = true; }
            
        }
        
        private void roundButton3_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0'))
            {}
            else if(this.textBox1.Text[this.textBox1.Text.Length - 1] != ')' && this.textBox1.Text.Length < 22) { this.textBox1.Text += '0'; }
        }
        Stopwatch sw = new Stopwatch();
        private void roundButton4_Click(object sender, EventArgs e)
        {   if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '1'); }
            else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '1'; }
            sw.Restart();
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '2'); }
            else if( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '2'; }
            sw.Restart();
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '3'); }
            else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '3'; }
            sw.Restart();
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '4'); }
            else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '4'; }
            sw.Restart();
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '5'); }
            else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '5'; }
            sw.Restart();
        }

        private void roundButton9_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '6'); }
            else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '6'; }
            sw.Restart();
        }

        private void roundButton12_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '7'); }
            else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '7'; }
            sw.Restart();
        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '8'); }
            else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '8'; }
            sw.Restart();
        }

        private void roundButton11_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '9'); }
            else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '9'; }
            sw.Restart();
        }
        bool math = false;
        

        private void roundButton4_DoubleClick(object sender, EventArgs e)
        {  if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-1"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ',') { this.textBox1.Text += "-1"; point = true; }
                else {
                      this.textBox1.Text += '1'; 
                     }
            }
            else 
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '1'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '1'; }
            }
        }

        private void roundButton7_DoubleClick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-2"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ',') { this.textBox1.Text += "-2"; point = true; }
                else 
                {
                     this.textBox1.Text += '2'; 
                }
            }
            else
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '2'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '2'; }
            }
        }

        private void roundButton6_DoubleClick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-3"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ',') { this.textBox1.Text += "-3"; point = true; }
                else
                {
                      this.textBox1.Text += '3'; 
                }
            }
            else
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '3'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '3'; }
            }
        }

        private void roundButton5_DoubleClick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-4"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ',') { this.textBox1.Text += "-4"; point = true; }
                else
                {
                      this.textBox1.Text += '4'; 
                }
            }
            else
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '4'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '4'; }
            }
        }

        private void roundButton8_DoubleClick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-5"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ',') { this.textBox1.Text += "-5"; point = true; }
                else
                {
                      this.textBox1.Text += '5'; 
                }
            }
            else
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '5'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '5'; }
            }
        }

        private void roundButton9_DoubleClick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-6"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ',') { this.textBox1.Text += "-6"; point = true; }
                else
                {
                     this.textBox1.Text += '6'; 
                }
            }
            else
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '6'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '6'; }
            }
        }

        private void roundButton12_DoubleClick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-7"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ',') { this.textBox1.Text += "-7"; point = true; }
                else
                {
                       this.textBox1.Text += '7'; 
                }
            }
            else
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '7'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '7'; }
            }
        }

        private void roundButton10_DoubleClick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-8"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ',') { this.textBox1.Text += "-8"; point = true; }
                else
                {  this.textBox1.Text += '8'; 
                }
            }
            else
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '8'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '8'; }
            }
        }

        private void roundButton11_DoubleClick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds <= 180 && this.textBox1.Text[this.textBox1.Text.Length - 1] != ')')
            {
                this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace("0", "-9"); }
                else if (this.textBox1.Text.Length < 21 && this.textBox1.Text[this.textBox1.Text.Length-1] != ',') { this.textBox1.Text += "-9";point = true; }
                else
                {
                      this.textBox1.Text += '9'; 
                }
            }
            else
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', '9'); }
                else if ( this.textBox1.Text[this.textBox1.Text.Length - 1] != ')') { this.textBox1.Text += '9'; }
            }
        }
        private void roundButton13_Click(object sender, EventArgs e)
        {
            if (!chek && Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
            {
                this.textBox2.Text += this.textBox1.Text + " + ";
                this.textBox2.Visible = true;
                this.textBox1.Text = " 0";
                math = true;
                point = true;
            }else if (Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
            {
                this.textBox2.Text = this.textBox1.Text + " + ";
                this.textBox2.Visible = true;
                this.textBox1.Text = " 0";
                math = true;
                point = true;
                chek = false;
            }
            this.textBox2.Text = this.textBox2.Text.Replace("  ", " ");
        }

        private void roundButton15_Click(object sender, EventArgs e)
        {
            if (!chek && Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
            {
                this.textBox2.Text += this.textBox1.Text + " - ";
                this.textBox2.Visible = true;
                this.textBox1.Text = " 0";
                math = true;
                point = true;
            }else if(Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
            {
                this.textBox2.Text = this.textBox1.Text + " - ";
                this.textBox2.Visible = true;
                this.textBox1.Text = " 0";
                math = true;
                point = true;
                chek = false;
            }
            this.textBox2.Text = this.textBox2.Text.Replace("  ", " ");
        }

        private void roundButton17_Click(object sender, EventArgs e)
        {
            if (!chek && Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
            {
                this.textBox2.Text += this.textBox1.Text + " × ";
                this.textBox2.Visible = true;
                this.textBox1.Text = " 0";
                math = true;
                point = true;
            }else if(Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
            {
                this.textBox2.Text = this.textBox1.Text + " × ";
                this.textBox2.Visible = true;
                this.textBox1.Text = " 0";
                math = true;
                point = true;
                chek = false;
            }
            this.textBox2.Text = this.textBox2.Text.Replace("  ", " ");
        }

        private void roundButton16_Click(object sender, EventArgs e)
        {
            
                if (!chek && Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
                {
                    this.textBox2.Text += this.textBox1.Text + " ÷ ";
                    this.textBox2.Visible = true;
                    this.textBox1.Text = " 0";
                    math = true;
                    point = true;
                }
                else if ( Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
                {
                    this.textBox2.Text = this.textBox1.Text + " ÷ ";
                    this.textBox2.Visible = true;
                    this.textBox1.Text = " 0";
                    math = true;
                    point = true;
                    chek = false;
                }
                this.textBox2.Text = this.textBox2.Text.Replace("  ", " ");
           
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Text = " 0";
            this.textBox2.Text = "";
            this.textBox2.Visible = false;
            point = true;
            skobki = true;
            math = false;
        }

        public static int Count(string str)
        {
            int i = 0;
            foreach (char l in str)
            {
                if (Convert.ToInt32(l) != 32) i++;
            }
            return i;
        }
        bool skobki = true;
        private void roundButton18_Click(object sender, EventArgs e)
        {
            if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0') && Convert.ToInt32(this.textBox1.Text[this.textBox1.Text.Length - 2]) == 32 ) { this.textBox1.Text = this.textBox1.Text.Replace('0', '(');  skobki = false; }
            else if (this.textBox1.Text.Length < 22 && Convert.ToInt32(this.textBox1.Text[this.textBox1.Text.Length - 1]) == 32 || this.textBox1.Text.Length < 22 && Convert.ToInt32(this.textBox1.Text[this.textBox1.Text.Length - 1]) == 94) { this.textBox1.Text += '('; skobki = false; }                        
        }

        private void roundButton19_Click(object sender, EventArgs e)
        {
            if (!skobki)
            {
                if (Count(this.textBox1.Text) == 1 && this.textBox1.Text.Contains('0')) { this.textBox1.Text = this.textBox1.Text.Replace('0', ')'); }
                else if (this.textBox1.Text.Length < 22) { this.textBox1.Text += ')'; }
                skobki = true;
                this.textBox3.Visible = false;                
            }
            
        }

        private void roundButton21_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text[this.textBox1.Text.Length - 1] != ',' && this.textBox1.Text[this.textBox1.Text.Length - 1] != '(')
            {
                this.textBox1.Text += '^';
                math = true;
                point = true;
            }
            
        }

        private void roundButton20_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text[this.textBox1.Text.Length-1] == ',') { point = true; }
            else if (this.textBox1.Text[this.textBox1.Text.Length - 1] == '(') { skobki = true; }
            else if (this.textBox1.Text[this.textBox1.Text.Length - 1] == ')') { skobki = false; }
            if (this.textBox1.Text[this.textBox1.Text.Length-2]!='-')this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1);
            else { this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 2, 2); }
        }

        private void roundButton23_Click(object sender, EventArgs e)
        { 
            CalculationEngine engine = new CalculationEngine();
            ExpressionContext context = new ExpressionContext();
            VariableCollection variables = context.Variables;
            try
            {
                if (this.textBox1.Text != " " && Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
                {
                    engine.Add("b", this.textBox1.Text, context);
                    try { this.textBox1.Text = " " + Math.Sin(engine.GetResult<double>("b") * Math.PI / 180).ToString(); }
                    catch (ArgumentException) { this.textBox1.Text = " " + Math.Sin(engine.GetResult<int>("b") * Math.PI / 180).ToString(); }
                }
            }catch  { }
        }

        private void roundButton22_Click(object sender, EventArgs e)
        {
            CalculationEngine engine = new CalculationEngine();
            ExpressionContext context = new ExpressionContext();
            VariableCollection variables = context.Variables;

            try
            {
                if (this.textBox1.Text != " " && Skobka(this.textBox1.Text) && skobki && Point(this.textBox1.Text) && Pow(this.textBox1.Text))
                {
                    
                    engine.Add("c", this.textBox1.Text, context);
                    try { this.textBox1.Text = " " + Math.Cos(engine.GetResult<double>("c") * Math.PI / 180).ToString(); }
                    catch (ArgumentException) { this.textBox1.Text = " " + Math.Cos(engine.GetResult<int>("c") * Math.PI / 180).ToString(); }
                }
            }catch  { }
            
        }
        public static bool Point(string str)//есть ли цифры после запятой
        {
            bool point = true;
            foreach (char i in str) 
            {
                if (str.IndexOf(',') != -1)
                {

                    try
                    {
                        if (Convert.ToInt32(str[str.IndexOf(',') + 1]) > 47 && Convert.ToInt32(str[str.IndexOf(',') + 1]) < 58)
                        {
                            str = str.Remove(str.IndexOf(','), 1);
                        }
                    }catch (IndexOutOfRangeException) { point = false; }                   
                }
            }
            return point;
        }
        public static bool Pow(string str)
        {
            bool pow = true;
            foreach (char i in str)
            {
                if (str.IndexOf('^') != -1)
                {

                    try
                    {
                        if (Convert.ToInt32(str[str.IndexOf('^') + 1]) == Convert.ToInt32(str[str.IndexOf('^') + 1]))
                        {
                            str = str.Remove(str.IndexOf('^'), 1);
                        }
                    }
                    catch (IndexOutOfRangeException) { pow = false; }
                }
            }
            return pow;
        }
        public static bool Skobka(string str)
        {
            bool skobka = true;
            foreach (char i in str)
            {
                if (str.IndexOf('(') != -1)
                {

                    try
                    {
                        if (str[str.IndexOf('(') + 1] != ')')
                        {
                            str = str.Remove(str.IndexOf('('), 1);
                        }
                        else { skobka = false; }
                    }
                    catch (IndexOutOfRangeException) { skobka = false; }
                }
            }
            return skobka;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }

}
