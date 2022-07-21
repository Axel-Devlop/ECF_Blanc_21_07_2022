using InputValidationLib;

namespace EcfBlanc
{
    public partial class FrmDemandeurEmploi : Form
    {
        private JobFinder jobFinder;

        public FrmDemandeurEmploi()
        {
            InitializeComponent();
            jobFinder = new JobFinder();
        }

        #region event
        /// <summary>
        /// Controle tout les champs de saisies et appelle la méthode AddJobSeeker si aucune erreure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidation_Click(object sender, EventArgs e)
        {
            bool result = true;

            if (!ValidateName(tbFirstName)) result = false;
            if (!ValidateName(tbLastName)) result = false;
            if (!ValidatePastYear(tb, 1950)) result = false;
            if (!ValidateTrainingLevel()) result = false;
            if (!ValidateDiplomaName()) result = false;
            if (!ValidatePastYear(tbLastDiplomaDate, 1950)) result = false;

            if (result)
            {

                AddJobSeeker();

            }


        }


        #endregion event

        /// <summary>
        /// Renvoi un élément de l'énum trainingLevel en fonction du texte de la comboBox
        /// </summary>
        /// <returns></returns>
        private trainingLevel FindTrainingLevelFromForm()
        {
            switch (cbTrainingLevel.Text)
            {
                case "InfBac":
                    return trainingLevel.InfBac;
                case "Bac":
                    return trainingLevel.Bac;
                case "Bac+1":
                    return trainingLevel.BacPlus1;
                case "Bac+2":
                    return trainingLevel.BacPlus2;
                case "Bac+3":
                    return trainingLevel.BacPlus3;
                case "Bac+4":
                    return trainingLevel.BacPlus4;
                case "Bac+5":
                    return trainingLevel.BacPLus5;
                case "SupBac+5":
                    return trainingLevel.SupBacPlus5;

                default:
                    return trainingLevel.InfBac;
            }
        }

        /// <summary>
        /// Instancie un nouveau JobSeeker et envoi un message rappelant ses caractéristiques
        /// </summary>
        private void AddJobSeeker()
        {
            JobSeeker newJobSeeker = new JobSeeker(
                tbFirstName.Text,
                tbLastName.Text,
                int.Parse(tb.Text),
                FindTrainingLevelFromForm(),
                tbLastDiplomaName.Text,
                int.Parse(tbLastDiplomaDate.Text),
                jobFinder
                );

            MessageBox.Show($"Nom : {newJobSeeker.LastName}\n Prénom : {newJobSeeker.FirstName}\n Id : {newJobSeeker.id}\n " +
                $"Année d'inscription : {newJobSeeker.inscriptionDate}\n Niveau de formation : {newJobSeeker.TrainingLevel}\n" +
                $"Nom du dernier diplôme : {newJobSeeker.NameOfLastDiploma}\n Date du dernier diplôme : {newJobSeeker.DateOfLastDiploma}\n" +
                $"Taux d'employabilité : {JobFinder.CalculateEmployability(newJobSeeker)}%", "Nouvel utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Utilise la librairie InputValidation pour savoir si le nom est valide
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>Renvoi si le nom est valide ou non</returns>
        private bool ValidateName(TextBox tb)
        {
            if (InputValidation.ValidateName(tb.Text))
            {
                GoodInput(tb);
                return true;
            }
            else
            {
                BadInput(tb);
                return false;
            }
        }

        private bool ValidateDiplomaName()
        {
            if (tbLastDiplomaName.Text.Length > 3 && tbLastDiplomaName.Text.Length < 50)
            {
                GoodInput(tbLastDiplomaName);
                return true;
            }
            else
            {
                BadInput(tbLastDiplomaName);
                return false;
            }
        }

        private bool ValidateTrainingLevel()
        {
            if(cbTrainingLevel.Text != String.Empty)
            {
                label6.ForeColor = Color.Black;
                label6.Font = new Font(label6.Font, FontStyle.Regular);
                return true;
            }
            else
            {
                label6.ForeColor = Color.Red;
                label6.Font = new Font(label6.Font, FontStyle.Bold);
                return false;
            }
            
        }

        /// <summary>
        /// Renvoi true si la date est supérieur à minYear et inférieur à l'année actuelle
        /// </summary>
        /// <param name="tb">Le textBox à controller</param>
        /// <param name="minYear">L'année minimale que l'on veut accepter</param>
        /// <returns></returns>
        private bool ValidatePastYear(TextBox tb, int minYear)
        {
            int year = 0;
            if (int.TryParse(tb.Text, out year) && year < DateTime.Now.Year && year > minYear)
            {
                GoodInput(tb);
                return true;
            }
            else
            {
                BadInput(tb);
                return false;
            }
        }



        /// <summary>
        /// Colore le Control en bleu et revient au font de départ
        /// </summary>
        /// <param name="ctrl"></param>
        private void GoodInput(Control ctrl)
        {
            ctrl.ForeColor = Color.Blue;
            ctrl.Font = new Font(ctrl.Font, FontStyle.Regular);
        }

        /// <summary>
        /// Colore le control en rouge et le met en gras
        /// </summary>
        /// <param name="ctrl"></param>
        private void BadInput(Control ctrl)
        {
            ctrl.ForeColor = Color.Red;
            ctrl.Font = new Font(ctrl.Font, FontStyle.Bold);
        }

    }
}