namespace BA_V1
{
    public partial class Frm_MainMenu : Form
    {
        private double aching, breathing_heavily, clear_speech, drained, drowsy, exhausted, fall_asleep, forgetful, hurting, indifferent, inefficient, lack_of_initiative,
            lazy, listless, numbness, out_of_breath, overworked, palpitations, passive, responsiveness, sleepy, spent, stiff_joints, sweaty, taste_of_blood,
            tense_muscles, unconcentrated, unfocused, uninterested, vigilant, worn_out, yawns, longing_to_lie_down, lack_of_energy, reduced_motivation_and_activity, sleepiness, reduced_mental_capacity, physical_exertion;
        string id;
        DateTime date;
        Frm_assessment assessment = new Frm_assessment();


        public Frm_MainMenu()
        {

            InitializeComponent();

        }
        //open Assessment Form and get variables after conduct of assessment
        private void conductAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            assessment.ShowDialog();
            if (assessment.DialogResult == DialogResult.OK)
            {
                aching = assessment.Aching / 100;
                breathing_heavily = assessment.BreathingHeavily / 100;
                clear_speech = assessment.ClearSpeech / 100;
                drained = assessment.Drained / 100;
                drowsy = assessment.Drowsy / 100;
                exhausted = assessment.Exhausted / 100;
                fall_asleep = assessment.FallAsleep / 100;
                forgetful = assessment.Forgetful / 100;
                hurting = assessment.Hurting / 100;
                indifferent = assessment.Indifferent / 100;
                inefficient = assessment.Indifferent / 100;
                lack_of_initiative = assessment.LackofInitiative / 100;
                lazy = assessment.Lazy / 100;
                listless = assessment.Listless / 100;
                numbness = assessment.Numbness / 100;
                out_of_breath = assessment.OutofBreath / 100;
                overworked = assessment.Overworked / 100;
                palpitations = assessment.Palpitations / 100;
                passive = assessment.Passive / 100;
                responsiveness = assessment.Responsiveness / 100;
                sleepy = assessment.Sleepy / 100;
                spent = assessment.Spent / 100;
                stiff_joints = assessment.StiffJoints / 100;
                sweaty = assessment.Sweaty / 100;
                taste_of_blood = assessment.TasteofBlood / 100;
                tense_muscles = assessment.TenseMuscles / 100;
                unconcentrated = assessment.Unconcentrated / 100;
                unfocused = assessment.Unfocused / 100;
                uninterested = assessment.Uninterested / 100;
                vigilant = assessment.Vigilant / 100;
                worn_out = assessment.WornOut / 100;
                yawns = assessment.Yawns / 100;
                longing_to_lie_down = assessment.longing_to_lie_down / 100;
                lack_of_energy = assessment.LackOfEnergy / 100;
                reduced_motivation_and_activity = assessment.ReducedMotivationAndActivity / 100;
                sleepiness = assessment.Sleepiness / 100;
                reduced_mental_capacity = assessment.ReducedMentalCapability / 100;
                physical_exertion = assessment.PhysicalExertion / 100;
                assessment.i = 0;

            }
            else
                return;


        }
        //exit the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //open graphical evaluation window and hand over all variables
        public void showLastResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_graphicalEvaluation graphEv = new Frm_graphicalEvaluation(aching, breathing_heavily, clear_speech, drained, drowsy, exhausted, fall_asleep, forgetful, hurting, indifferent, inefficient, lack_of_initiative,
           lazy, listless, numbness, out_of_breath, overworked, palpitations, passive, responsiveness, sleepy, spent, stiff_joints, sweaty, taste_of_blood,
           tense_muscles, unconcentrated, unfocused, uninterested, vigilant, worn_out, yawns, longing_to_lie_down, lack_of_energy, reduced_motivation_and_activity, sleepiness, reduced_mental_capacity, physical_exertion);

            graphEv.ShowDialog();
            graphEv.Close();
            
           
        }

      
        //export variables incl. an identifier and a timestamp to .csv
        private void exportLastResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                date = DateTime.Now;
                Input input = new Input();
                input.ShowDialog();
                if (input.DialogResult == DialogResult.OK)
                    id = input.ID;
                string savefilepath = saveFileDialog.FileName;
                FileStream fileStream = new(savefilepath, FileMode.Create);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine("ID;" + $"{Convert.ToString(id)}");
                writer.WriteLine("date;" + $" {Convert.ToString(date)}");
                writer.WriteLine("lack_of_energy;" + $"{Convert.ToString(lack_of_energy)}");
                writer.WriteLine("drained;" + $" {Convert.ToString(drained)}");
                writer.WriteLine("exhausted;" + $"{Convert.ToString(exhausted)}");
                writer.WriteLine("overworked;" + $" {Convert.ToString(overworked)}");
                writer.WriteLine("spent;" + $" {Convert.ToString(spent)}");
                writer.WriteLine("worn_out;" + $" {Convert.ToString(worn_out)}");
                writer.WriteLine("reduced_motivation_and_activity;" + $"{Convert.ToString(reduced_motivation_and_activity)}");
                writer.WriteLine("indifferent;" + $"{Convert.ToString(indifferent)}");
                writer.WriteLine("inefficient;" + $"{Convert.ToString(inefficient)}");
                writer.WriteLine("lack_of_initiative;" + $"{Convert.ToString(lack_of_initiative)}");
                writer.WriteLine("listless;" + $"{Convert.ToString(listless)}");
                writer.WriteLine("passive;" + $"{Convert.ToString(passive)}");
                writer.WriteLine("responsiveness;" + $"{Convert.ToString(responsiveness)}");
                writer.WriteLine("uninterested;" + $"{Convert.ToString(uninterested)}");
                writer.WriteLine("longing_to_lie_down;" + $"{Convert.ToString(longing_to_lie_down)}");
                writer.WriteLine("sleepiness;" + $"{Convert.ToString(sleepiness)}");
                writer.WriteLine("drowsy;" + $"{Convert.ToString(drowsy)}");
                writer.WriteLine("fall_asleep; " + $"{Convert.ToString(fall_asleep)}");
                writer.WriteLine("lazy;" + $"{Convert.ToString(lazy)}");
                writer.WriteLine("sleepy;" + $"{Convert.ToString(sleepy)}");
                writer.WriteLine("vigilant;" + $"{Convert.ToString(vigilant)}");
                writer.WriteLine("yawns;" + $"{Convert.ToString(yawns)}");
                writer.WriteLine("reduced_mental_capacity;" + $"{Convert.ToString(reduced_mental_capacity)}");
                writer.WriteLine("clear_speech;" + $"{Convert.ToString(clear_speech)}");
                writer.WriteLine("forgetful;" + $"{Convert.ToString(forgetful)}");
                writer.WriteLine("unconcentrated;" + $"{Convert.ToString(unconcentrated)}");
                writer.WriteLine("unfocused;" + $"{Convert.ToString(unfocused)}");
                writer.WriteLine("physical_exertion;" + $"{Convert.ToString(physical_exertion)}");
                writer.WriteLine("aching;" + $"{Convert.ToString(aching)}");
                writer.WriteLine("breathing_heavily;" + $"{Convert.ToString(breathing_heavily)}");
                writer.WriteLine("hurting;" + $"{Convert.ToString(hurting)}");
                writer.WriteLine("numbness;" + $"{Convert.ToString(numbness)}");
                writer.WriteLine("out_of_breath;" + $"{Convert.ToString(out_of_breath)}");
                writer.WriteLine("palpitations;" + $"{Convert.ToString(palpitations)}");
                writer.WriteLine("stiff_joints;" + $"{Convert.ToString(stiff_joints)}");
                writer.WriteLine("sweaty;" + $"{Convert.ToString(sweaty)}");
                writer.WriteLine("taste_of_blood;" + $"{Convert.ToString(taste_of_blood)}");
                writer.WriteLine("tense_muscles;" + $"{Convert.ToString(tense_muscles)}");
                writer.Close();
            }

        }

       
        private void Frm_MainMenu_Load(object sender, EventArgs e)
        {

        }
        //import variables from .csv to the program. Timestamp and Identifier are dropped
        private void importResultsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            fileDialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new(fileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() > -1)
                {
                   
                    string zeile = sr.ReadLine();
                    if (zeile != null)
                    {
                        string[] teile = zeile.Split(";");
                        string kennzeichner = teile[0];
                      
                        if (kennzeichner == "lack_of_energy") { lack_of_energy = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "drained") { drained = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "exhausted") { exhausted = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "overworked") { overworked = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "spent") { spent = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "worn_out") { worn_out = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "reduced_motivation_and_activity") { reduced_motivation_and_activity = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "indifferent") { indifferent = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "inefficient") { inefficient = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "lack_of_initiative") { lack_of_initiative = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "listless") { listless = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "passive") { passive = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "responsiveness") { responsiveness = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "uninterested") { uninterested = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "longing_to_lie_down") { longing_to_lie_down = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "sleepiness") { sleepiness = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "drowsy") { drowsy = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "fall_asleep") { fall_asleep = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "lazy") { lazy = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "sleepy") { sleepy = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "vigilant") { vigilant = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "yawns") { yawns = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "reduced_mental_capacity") { reduced_mental_capacity = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "clear_speech") { clear_speech = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "forgetful") { forgetful = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "unconcentrated") { unconcentrated = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "unfocused") { unfocused = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "physical_exertion") { physical_exertion = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "aching") { aching = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "breathing_heavily") { breathing_heavily = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "hurting") { hurting = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "numbness") { numbness = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "out_of_breath") { out_of_breath = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "palpitations") { palpitations = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "stiff_joints") { stiff_joints = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "sweaty") { sweaty = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "taste_of_blood") { taste_of_blood = Convert.ToDouble(teile[1]); }
                        if (kennzeichner == "tense_muscles") { tense_muscles = Convert.ToDouble(teile[1]); }
                     



                    }
                }
                sr.Close();

            }
            else MessageBox.Show("Datei konnte nicht gelesen werden", "Fehler");
        }
    }


}
