using System;

namespace MMayinTarlasi
{
    public partial class FormScoreBoard : MetroFramework.Forms.MetroForm
    {
        ScoreSystem scoreData = ScoreSystem.GetInstance();

        public FormScoreBoard()
        {
            InitializeComponent();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            dataGridScore.StyleManager = StyleManager;

            dataGridScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;

            dataGridScore.DataSource = scoreData.GetScoreDateTable();
        }
    }
}
