using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Supercalifragalistic
{
    class BMIcheck
    {
        float height;
        float weight;
        string g_weight;
        string g_height;
        float BMI;
        List<float> bmilist = new List<float> { };


        public void GetInput(TextBox boxheight, TextBox boxweight)
        {
            g_height = boxheight.Text.Replace(" ", "");
            g_weight = boxweight.Text.Replace(" ", "");





            if (g_weight.All(char.IsNumber) && g_weight.All(char.IsNumber))
            {




                this.height = Convert.ToSingle(g_height);

                this.weight = Convert.ToSingle(g_weight);
                CalculateBMI();

            }

            else
            {
                this.height = 0;
                this.weight = 0;

            }



        }

        float CalculateBMI()
        {
            this.BMI = weight / height / height * 10000;
            bmilist.Add(this.BMI);


            return this.BMI;
        }

        public string GiveBMI(ref Label outbox)
        {
            string result = Convert.ToString(this.BMI);

            outbox.Text = result;


            return result;

        }
        public void PrintBMIList(ListView outbox)
        {

            outbox.Items.Clear();
            if (bmilist.Count == 0)
            {
                
            }

            else
            {
                
                outbox.Items.Add(bmilist[0].ToString());
                for (int i = 1; i < bmilist.Count; i++)
                {

                    outbox.Items.Add(bmilist[i].ToString());
                }
            }
        }

    }
}
