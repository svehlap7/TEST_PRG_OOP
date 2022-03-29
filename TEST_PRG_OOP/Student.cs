using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_PRG_OOP
{
    class Student
    {
        //Nic me nenapada Chybi mi fantazie

        private string jmeno;
        private int vek;
        private int znamky;
        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                jmeno = value;
                if (value == "")
                {
                    MessageBox.Show("NEZADANE UDAJE");
                }
            }
        }

        public int Znamky
        {
            get
            {
                if (znamky == 0)
                {
                    MessageBox.Show("NEZADANE UDAJE");
                }
                return znamky;
            }
            set
            {
                if (value <= 5 && value >= 1)
                {
                    znamky = value;
                }
                else
                {
                    znamky = 0;
                }
            }
        }

        public bool Prospel
        {
            get; 
            private set;
        }
        public Student(string jmeno, int vek, int znamky)
        {
            Jmeno = jmeno;
            this.vek = vek;
            this.znamky = znamky;
        }
        public Student()
        {
        }

        public double Znamka()
        {
            if (znamky < 4)
            {
                Prospel = true;
            }
            else
            {
                Prospel = false;

            }
            return znamky;
        }

        public override string ToString()
        {
            return String.Format("Zak: {0}\n ma: {1} let \n jeho znamka je: {2} \n {3}", Jmeno, vek, Znamky ,Prospel ? "PROSPEL" : "NEPROSPEL");
        }
    }
}



