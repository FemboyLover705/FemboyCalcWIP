namespace Aufgabe_1_Taschenrechner
{
    public partial class Form1 : Form
    {
        // variablen als platzhalter für die rechnungen und ausgabe
        private decimal wert1 = 0.0m;
        private decimal wert2 = 0.0m;
        private decimal ergebnis = 0.0m;
        private string operatoren = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void anzeige_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void knopfsieben_Click(object sender, EventArgs e)
        {
            // gibt die nummer 7 im texfeld an 
            anzeige.Text += "7";
        }

        private void knopfacht_Click(object sender, EventArgs e)
        {
            // gibt die nummer 8 im texfeld an 
            anzeige.Text += "8";
        }

        private void knopfneun_Click(object sender, EventArgs e)
        {
            // gibt die nummer 9 im texfeld an 
            anzeige.Text += "9";
        }

        private void knopfwurzel_Click(object sender, EventArgs e)
        {
            // formel und ausgabe von wurzel ziehen
            double zahl = double.Parse(anzeige.Text);
            double ergebnis = Math.Sqrt(zahl);
            anzeige.Text = ergebnis.ToString();
        }

        private void knopfdividiert_Click(object sender, EventArgs e)
        {
            // ändert den platzhalter um die rechnung dann beim case zu ändern
            wert1 = decimal.Parse(anzeige.Text);
            anzeige.Clear();
            operatoren = "/";
        }

        private void knopfpotenzieren_Click(object sender, EventArgs e)
        {
            // ändert den platzhalter um die rechnung dann beim case zu ändern
            wert1 = decimal.Parse(anzeige.Text);
            anzeige.Clear();
            operatoren = "^";
        }

        private void knopfzwei_Click(object sender, EventArgs e)
        {
            // gibt die nummer 2 im texfeld an 
            anzeige.Text += "2";
        }

        private void knopfnull_Click(object sender, EventArgs e)
        {
            // gibt die nummer 0 im texfeld an (wenne es eine null schon gibt dann wird keien weitere hinein gefügt)
            if (anzeige.Text != "0")
            {
                anzeige.Text += "0";
            }
        }

        private void knopfergebnis_Click(object sender, EventArgs e)
        {
            // verwendet den 2. wert und rechnet es mit dem gewünschtem operator
            wert2 = decimal.Parse(anzeige.Text);
            switch (operatoren)
            {
                case "+":
                    ergebnis = wert1 + wert2;
                    break;
                case "-":
                    ergebnis = wert1 - wert2;
                    break;
                case "*":
                    ergebnis = wert1 * wert2;
                    break;
                case "/":
                    if (wert2 != 0)
                    {
                        ergebnis = wert1 / wert2;
                    }
                    else
                    {
                        // fehler wird angezeigt falls durch 0 dividiert wird
                        MessageBox.Show("FEHLER (kann nicht durch 0 divdiert werden)");
                        anzeige.Clear();
                        return;
                    }
                    break;
                case "^":
                    // formel zum potenzieren 
                    ergebnis = (decimal)Math.Pow((double)wert1, (double)wert2);
                    break;
            }
            // ausgabe
            anzeige.Text = ergebnis.ToString();

        }

        private void knopfcomma_Click(object sender, EventArgs e)
        {
            // fügt ein komma ein (kann nur ein mal benutzt werden)
            if (!anzeige.Text.Contains("."))
            {
                anzeige.Text += ".";
            }
        }

        private void knopfeins_Click(object sender, EventArgs e)
        {
            // gibt die nummer 1 im texfeld an 
            anzeige.Text += "1";
        }

        private void knopfminus_Click(object sender, EventArgs e)
        {
            // ändert den platzhalter um die rechnung dann beim case zu ändern
            wert1 = decimal.Parse(anzeige.Text);
            anzeige.Clear();
            operatoren = "-";
        }

        private void knopfmal_Click(object sender, EventArgs e)
        {
            // ändert den platzhalter um die rechnung dann beim case zu ändern
            wert1 = decimal.Parse(anzeige.Text);
            anzeige.Clear();
            operatoren = "*";
        }

        private void knopfdrei_Click(object sender, EventArgs e)
        {
            // gibt die nummer 3 im texfeld an 
            anzeige.Text += "3";
        }

        private void knopfvier_Click(object sender, EventArgs e)
        {
            // gibt die nummer 4 im texfeld an 
            anzeige.Text += "4";
        }

        private void knopffünf_Click(object sender, EventArgs e)
        {
            // gibt die nummer 5 im texfeld an 
            anzeige.Text += "5";
        }

        private void buttonsechs_Click(object sender, EventArgs e)
        {
            // gibt die nummer 6 im texfeld an 
            anzeige.Text += "6";
        }

        private void knopfplus_Click(object sender, EventArgs e)
        {
            // ändert den platzhalter um die rechnung dann beim case zu ändern
            wert1 = decimal.Parse(anzeige.Text);
            anzeige.Clear();
            operatoren = "+";
        }

        private void knopflogarithmus_Click(object sender, EventArgs e)
        {
            // führt die formel aus um den logarithmus zu berechnen und gibt diesen aus 
            decimal wert1 = decimal.Parse(anzeige.Text);
            decimal ergebnis = (decimal)Math.Log10((double)wert1);
            anzeige.Text = ergebnis.ToString();
        }

        private void knopffakultat_Click(object sender, EventArgs e)
        {
            // führt die methode der berechnung von fakultät und gibt diese aus 
            int wert1 = int.Parse(anzeige.Text);
            if (wert1 < 0)
            {
                MessageBox.Show("Die Fakultät ist nur für nicht-negative Zahlen definiert.");
                return;
            }
            long ergebnis = Fakultat(wert1);
            anzeige.Text = ergebnis.ToString();
        }

        private void knopfclear_Click_1(object sender, EventArgs e)
        {
            // leert die eingabe
            anzeige.Clear();
        }

        private void knofsinus_Click(object sender, EventArgs e)
        {
            // führt die formel für sinus aus und gibt diese aus
            decimal wert1 = decimal.Parse(anzeige.Text);
            decimal ergebnis = (decimal)Math.Sin((double)wert1);
            anzeige.Text = ergebnis.ToString("F10");
        }

        private void knopfcosinus_Click(object sender, EventArgs e)
        {
            // führt die formel für cosinus aus und gibt diese aus
            decimal wert1 = decimal.Parse(anzeige.Text);
            decimal ergebnis = (decimal)Math.Cos((double)wert1);
            anzeige.Text = ergebnis.ToString("F10");
        }

        private void knopftangens_Click(object sender, EventArgs e)
        {
            // führt die formel für tangens aus und gibt diese aus
            decimal wert1 = decimal.Parse(anzeige.Text);
            decimal ergebnis = (decimal)Math.Tan((double)wert1);
            anzeige.Text = ergebnis.ToString("F10");
        }


        private int Fakultat(int wert1)
        {
            // methode zur berechnung der fakultät
            if (wert1 == 0)
            {
                return 1;
            }

            long ergebnis = 1;
            for (int wert2 = 1; wert2 <= wert1; wert2++)
            {
                ergebnis *= wert2;
            }
            return (int)ergebnis;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}