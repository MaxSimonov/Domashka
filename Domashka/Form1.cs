using Microsoft.SolverFoundation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domashka
{
    public partial class Form1 : Form
    {
        obogrev sm = new obogrev();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Grafick.Parent = null;
            PotA1.Text = "80";
            sm.Pot_A1 = 80d;
            PotA2.Text = "90";
            sm.Pot_A2 = 90d;
            PotA3.Text = "70";
            sm.Pot_A3 = 70d;
            PotA4.Text = "60";
            sm.Pot_A4 = 60d;
            TepT1A1.Text = "4";
            sm.Tep_T1_A1 = 4d;
            TepT1A2.Text = "3";
            sm.Tep_T1_A2 = 3d;
            TepT1A3.Text = "12";
            sm.Tep_T1_A3 = 12d;
            TepT1A4.Text = "2";
            sm.Tep_T1_A4 = 2d;
            TepT2A1.Text = "5";
            sm.Tep_T2_A1 = 5d;
            TepT2A2.Text = "5";
            sm.Tep_T2_A2 = 5d;
            TepT2A3.Text = "14";
            sm.Tep_T2_A3 = 14d;
            TepT2A4.Text = "5";
            sm.Tep_T2_A4 = 5d;
            TepT3A1.Text = "10";
            sm.Tep_T3_A1 = 10d;
            TepT3A2.Text = "3";
            sm.Tep_T3_A2 = 3d;
            TepT3A3.Text = "15";
            sm.Tep_T3_A3 = 15d;
            TepT3A4.Text = "6";
            sm.Tep_T3_A4 = 6d;
            ZapT1.Text = "140";
            sm.Zap_T1 = 140d;
            ZapT2.Text = "160";
            sm.Zap_T2 = 160d;
            ZapT3.Text = "100";
            sm.Zap_T3 = 100d;

            sm.Ras_A1_T1 = 4.222d;
            sm.Ras_A2_T1 = 7.620d;
            sm.Ras_A3_T1 = 7.874d;
            sm.Ras_A4_T1 = 2.877d;
            sm.Ras_A1_T2 = 4.385d;
            sm.Ras_A2_T2 = 10.870d;
            sm.Ras_A3_T2 = 4.064d;
            sm.Ras_A4_T2 = 5.363d;
            sm.Ras_A1_T3 = 4.118d;
            sm.Ras_A2_T3 = 6.522d;
            sm.Ras_A3_T3 = 0.788d;
            sm.Ras_A4_T3 = 4.570d;

            RasT1A1.Text = "4.222";
            RasT1A2.Text = "7.620";
            RasT1A3.Text = "7.874";
            RasT1A4.Text = "2.877";
            RasT2A1.Text = "4.385";
            RasT2A2.Text = "10.870";
            RasT2A3.Text = "4.064";
            RasT2A4.Text = "5.363";
            RasT3A1.Text = "4.118";
            RasT3A2.Text = "6.522";
            RasT3A3.Text = "0.788";
            RasT3A4.Text = "4.570";


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Raschot_Click(object sender, EventArgs e)
        {
          

            if (
            #region---
               (PotA1.Text == "") ||
               (PotA2.Text == "") ||
               (PotA3.Text == "") ||
               (PotA4.Text == "") ||
               (TepT1A1.Text == "") ||
               (TepT1A2.Text == "") ||
               (TepT1A3.Text == "") ||
               (TepT1A4.Text == "") ||
               (TepT2A1.Text == "") ||
               (TepT2A2.Text == "") ||
               (TepT2A3.Text == "") ||
               (TepT2A4.Text == "") ||
               (TepT3A1.Text == "") ||
               (TepT3A2.Text == "") ||
               (TepT3A3.Text == "") ||
               (TepT3A4.Text == ""))
            #endregion---
            {
                Grafick.Parent = null;
                MessageBox.Show("Не все поля заполнены!", "Ошибка");
                return;
            }

            else
            {

                Grafick.Parent = tabControl1;

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                chart1.Series[3].Points.Clear();
                chart2.Series[0].Points.Clear();
                chart2.Series[1].Points.Clear();
                chart2.Series[2].Points.Clear();
                chart2.Series[3].Points.Clear();
                chart3.Series[0].Points.Clear();
                chart3.Series[1].Points.Clear();
                chart3.Series[2].Points.Clear();
                chart3.Series[3].Points.Clear();

                sm.Pot_A1 = Double.Parse(PotA1.Text);
                sm.Pot_A2 = Double.Parse(PotA2.Text);
                sm.Pot_A3 = Double.Parse(PotA3.Text);
                sm.Pot_A4 = Double.Parse(PotA4.Text);
                sm.Tep_T1_A1 = Double.Parse(TepT1A1.Text);
                sm.Tep_T1_A2 = Double.Parse(TepT1A2.Text);
                sm.Tep_T1_A3 = Double.Parse(TepT1A3.Text);
                sm.Tep_T1_A4 = Double.Parse(TepT1A4.Text);
                sm.Tep_T2_A1 = Double.Parse(TepT2A1.Text);
                sm.Tep_T2_A2 = Double.Parse(TepT2A2.Text);
                sm.Tep_T2_A3 = Double.Parse(TepT2A3.Text);
                sm.Tep_T2_A4 = Double.Parse(TepT2A4.Text);
                sm.Tep_T3_A1 = Double.Parse(TepT3A1.Text);
                sm.Tep_T3_A2 = Double.Parse(TepT3A2.Text);
                sm.Tep_T3_A3 = Double.Parse(TepT3A3.Text);
                sm.Tep_T3_A4 = Double.Parse(TepT3A4.Text);
                sm.Zap_T1 = Double.Parse(ZapT1.Text);
                sm.Zap_T2 = Double.Parse(ZapT2.Text);
                sm.Zap_T3 = Double.Parse(ZapT3.Text);

                List<SolverRow> solverList = new List<SolverRow>();
                solverList.Add(new SolverRow { xId = 1, Koef = sm.Ras_A1_T1 });
                solverList.Add(new SolverRow { xId = 2, Koef = sm.Ras_A2_T1 });
                solverList.Add(new SolverRow { xId = 3, Koef = sm.Ras_A3_T1 });
                solverList.Add(new SolverRow { xId = 4, Koef = sm.Ras_A4_T1 });
                solverList.Add(new SolverRow { xId = 5, Koef = sm.Ras_A1_T2 });
                solverList.Add(new SolverRow { xId = 6, Koef = sm.Ras_A2_T2 });
                solverList.Add(new SolverRow { xId = 7, Koef = sm.Ras_A3_T2 });
                solverList.Add(new SolverRow { xId = 8, Koef = sm.Ras_A4_T2 });
                solverList.Add(new SolverRow { xId = 9, Koef = sm.Ras_A1_T3 });
                solverList.Add(new SolverRow { xId = 10, Koef = sm.Ras_A2_T3 });
                solverList.Add(new SolverRow { xId = 11, Koef = sm.Ras_A3_T3 });
                solverList.Add(new SolverRow { xId = 12, Koef = sm.Ras_A4_T3 });

                SolverContext context = SolverContext.GetContext();               
                Model model = context.CreateModel();
                Set users = new Set(Domain.Any, "users");

                Parameter Koef = new Parameter(Domain.Real, "Koef", users);
                Koef.SetBinding(solverList, "Koef", "xId");
                model.AddParameter(Koef);

                Decision choose = new Decision(Domain.RealNonnegative, "choose", users);
                model.AddDecisions(choose);
                model.AddGoal("goal", GoalKind.Minimize, Model.Sum(Model.ForEach(users, xId => choose[xId] * Koef[xId])));

               

                model.AddConstraint("OgranT1", Model.Sum(Model.ForEach(users, xId => sm.Ras_A1_T1 * sm.Tep_T1_A1 + sm.Ras_A2_T1 * sm.Tep_T1_A2 + sm.Ras_A3_T1 * sm.Tep_T1_A3 + sm.Ras_A4_T1 * sm.Tep_T1_A4)) <= sm.Zap_T1);
                model.AddConstraint("OgranT2", Model.Sum(Model.ForEach(users, xId => sm.Ras_A1_T2 * sm.Tep_T2_A1 + sm.Ras_A2_T2 * sm.Tep_T2_A2 + sm.Ras_A3_T2 * sm.Tep_T2_A3 + sm. Ras_A4_T2 * sm.Tep_T2_A4)) <= sm.Zap_T2);
                model.AddConstraint("OgranT3", Model.Sum(Model.ForEach(users, xId => sm.Ras_A1_T3 * sm.Tep_T3_A1 + sm.Ras_A2_T3 * sm.Tep_T3_A2 + sm.Ras_A3_T3 * sm.Tep_T3_A3 + sm.Ras_A4_T3 * sm.Tep_T3_A4)) <= sm.Zap_T3);
                model.AddConstraint("OgranA1", Model.Sum(Model.ForEach(users, xId => sm.Ras_A1_T1 * sm.Tep_T1_A1 + sm.Ras_A1_T2 * sm.Tep_T2_A1 + sm.Ras_A1_T3 * sm.Tep_T3_A1)) >= sm.Pot_A1);
                model.AddConstraint("OgranA2", Model.Sum(Model.ForEach(users, xId => sm.Ras_A2_T1 * sm.Tep_T1_A2 + sm.Ras_A2_T2 * sm.Tep_T2_A2 + sm.Ras_A2_T3 * sm.Tep_T3_A2)) >= sm.Pot_A2);
                model.AddConstraint("OgranA3", Model.Sum(Model.ForEach(users, xId => sm.Ras_A3_T1 * sm.Tep_T1_A3 + sm.Ras_A3_T2 * sm.Tep_T2_A3 + sm.Ras_A3_T3 * sm.Tep_T3_A3)) >= sm.Pot_A3);
                model.AddConstraint("OgranA4", Model.Sum(Model.ForEach(users, xId => sm.Ras_A4_T1 * sm.Tep_T1_A4 + sm.Ras_A4_T2 * sm.Tep_T2_A4 + sm.Ras_A4_T3 * sm.Tep_T3_A4)) >= sm.Pot_A4);

                try
                {
                    Solution solution = context.Solve();
                    Report report = solution.GetReport();

                    String reportStr = "";

                    for (int i = 0; i < solverList.Count; i++)
                    {
                        reportStr += "Значение X" + (i + 1).ToString() + ": " + choose.GetDouble(solverList[i].xId) + "\n";
                    }
                    reportStr += "\n" + report.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("При решении задачи оптимизации возникла исключительная ситуация.");
                }

                double Ras_A1_T1 = Math.Round(choose.GetDouble(solverList[0].xId), 3);
                double Ras_A2_T1 = Math.Round(choose.GetDouble(solverList[1].xId), 3);
                double Ras_A3_T1 = Math.Round(choose.GetDouble(solverList[2].xId), 3);
                double Ras_A4_T1 = Math.Round(choose.GetDouble(solverList[3].xId), 3);
                double Ras_A1_T2 = Math.Round(choose.GetDouble(solverList[4].xId), 3);
                double Ras_A2_T2 = Math.Round(choose.GetDouble(solverList[5].xId), 3);
                double Ras_A3_T2 = Math.Round(choose.GetDouble(solverList[6].xId), 3);
                double Ras_A4_T2 = Math.Round(choose.GetDouble(solverList[7].xId), 3);
                double Ras_A1_T3 = Math.Round(choose.GetDouble(solverList[8].xId), 3);
                double Ras_A2_T3 = Math.Round(choose.GetDouble(solverList[9].xId), 3);
                double Ras_A3_T3 = Math.Round(choose.GetDouble(solverList[10].xId), 3);
                double Ras_A4_T3 = Math.Round(choose.GetDouble(solverList[11].xId), 3);

                this.chart1.Series[0].Points.AddXY("", sm.Ras_A1_T1);
                this.chart1.Series[1].Points.AddXY("", sm.Ras_A2_T1);
                this.chart1.Series[2].Points.AddXY("", sm.Ras_A3_T1);
                this.chart1.Series[3].Points.AddXY("", sm.Ras_A4_T1);
                this.chart2.Series[0].Points.AddXY("", sm.Ras_A1_T2);
                this.chart2.Series[1].Points.AddXY("", sm.Ras_A2_T2);
                this.chart2.Series[2].Points.AddXY("", sm.Ras_A3_T2);
                this.chart2.Series[3].Points.AddXY("", sm.Ras_A4_T2);
                this.chart3.Series[0].Points.AddXY("", sm.Ras_A1_T3);
                this.chart3.Series[1].Points.AddXY("", sm.Ras_A2_T3);
                this.chart3.Series[2].Points.AddXY("", sm.Ras_A3_T3);
                this.chart3.Series[3].Points.AddXY("", sm.Ras_A4_T3);

                dataGridView1.Rows.Add(sm.Ras_A1_T1, sm.Ras_A2_T1, sm.Ras_A3_T1, sm.Ras_A4_T1, sm.Ras_A1_T2, sm.Ras_A2_T2, sm.Ras_A3_T2, sm.Ras_A4_T2, sm.Ras_A1_T3, sm.Ras_A2_T3, sm.Ras_A3_T3, sm.Ras_A4_T3);






               

            }


           
            




           
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    


