using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoPladeGenerator
{
    public partial class BingoPlade : Form
    {
        Random r = new Random();
        SavingImage SI = new SavingImage();
        int picNumber = 1000;
        public BingoPlade()
        {
            
            InitializeComponent();
           
           

        }

        public void initializeNumbers(int y)
        {
            
            int Initialx = 47;
            int FiveNumbers = 5;
            // Creating new labels
            IEnumerable<int> MyRandoms = Enumerable.Range(1, 90).OrderBy(x => r.Next()).Take(15);
            List<int> MyListRandoms = MyRandoms.OrderBy(x => x).ToList();
            
           

            int LowestNumber = 1;
            int HighestNumber = 9;
            for (int i = 0; i < 9; i++)
            {
                int number = r.Next(0, 2);
                int boxesLeft = 9 - i ;

               
                int randNum = 0;
                if ((number == 0 || FiveNumbers >= boxesLeft) && FiveNumbers != 0)
                {
                    if (LowestNumber == 1)
                    {
                        randNum = r.Next(LowestNumber, HighestNumber);

                        LowestNumber = LowestNumber + 9;
                        HighestNumber = HighestNumber + 10;
                    }
                    else if (LowestNumber != 1 && HighestNumber != 79)
                    {
                        randNum = r.Next(LowestNumber, HighestNumber);

                        LowestNumber = LowestNumber + 10;
                        HighestNumber = HighestNumber + 10;
                    }
                    else if (HighestNumber == 79)
                    {
                        randNum = r.Next(LowestNumber, HighestNumber);

                        LowestNumber = LowestNumber + 10;
                        HighestNumber = HighestNumber + 11;
                    }

                    

                    Label namelabel = new Label();
                        Controls.Add(namelabel);
                        namelabel.Location = new Point(Initialx, y);
                        namelabel.BringToFront();
                        namelabel.BackColor = Color.White;
                        namelabel.AllowDrop = true;
                        namelabel.Name = "labels";
                        namelabel.Font = new Font("Microsoft Sans Serif", 30);
                        namelabel.Text = randNum.ToString();
                        namelabel.AutoSize = true;
                        FiveNumbers--;
                        Initialx = Initialx + 78;
                        
                        

                    }
                    
                  
              
                 
                
                else
                {
                    if (LowestNumber == 1)
                    {
                        LowestNumber = LowestNumber + 9;
                        HighestNumber = HighestNumber + 10;
                    }
                    else if (LowestNumber != 1 && HighestNumber != 79)
                    {
                        LowestNumber = LowestNumber + 10;
                        HighestNumber = HighestNumber + 10;
                    }
                    else if(HighestNumber == 79)
                    {
                        LowestNumber = LowestNumber + 10;
                        HighestNumber = HighestNumber + 11;
                    }
                    

                    Initialx = Initialx + 80;
                   
                }
               
                
            }
           
        }

        

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BingoPlade_Load(object sender, EventArgs e)
        {

        }

        private void BingoPlade_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            picNumber++;
            if (e.KeyChar == (char)Keys.Space)
            {
                SI.getCaption(picNumber);
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                //to remove control by Name
                foreach (Control item in Controls)
                {
                    if (item.Name == "labels")
                    {
                        Controls.Remove(item);
                        //important step
                    }
                }
                foreach (Control item in Controls)
                {
                    if (item.Name == "labels")
                    {
                        Controls.Remove(item);
                        //important step
                    }
                }
                foreach (Control item in Controls)
                {
                    if (item.Name == "labels")
                    {
                        Controls.Remove(item);
                        //important step
                    }
                }
                foreach (Control item in Controls)
                {
                    if (item.Name == "labels")
                    {
                        Controls.Remove(item);
                        //important step
                    }
                }
                foreach (Control item in Controls)
                {
                    if (item.Name == "labels")
                    {
                        Controls.Remove(item);
                        //important step
                    }
                }
                foreach (Control item in Controls)
                {
                    if (item.Name == "labels")
                    {
                        Controls.Remove(item);
                        //important step
                    }
                }

                initializeNumbers(124);
                initializeNumbers(195);
                initializeNumbers(270);
            }
            
            
        }
    }
}
