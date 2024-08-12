namespace BA_V1
{
    public partial class Frm_assessment : Form
    {
        public double aching, breathing_heavily, clear_speech, drained, drowsy, exhausted, fall_asleep, forgetful, hurting, indifferent, inefficient, lack_of_initiative,
             lazy, listless, numbness, out_of_breath, overworked, palpitations, passive, responsiveness, sleepy, spent, stiff_joints, sweaty, taste_of_blood,
             tense_muscles, unconcentrated, unfocused, uninterested, vigilant, worn_out, yawns, longing_to_lie_down, lack_of_energy, reduced_motivation_and_activity, sleepiness, reduced_mental_capacity, physical_exertion;

        //Variable used for navigating the steps of the questionnaire
        public int i = 0;

        public Frm_assessment()
        {

            InitializeComponent();
            RefreshPage();

        }

        private void bnt_next_Click(object sender, EventArgs e)
        {
            CollectVariables();
            i++;
            if (i > 35)
            {
                i = 0;
            }
            RefreshPage();
          


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
              
                //if database is integrated, delete entry of run
                i = 0;

            }
            RefreshPage();

            //if the first step is reached and the user wants to end the questionnaire, this button will close the questionnaire

        }
       
        //pretty self explanatory
        public void CollectVariables()
        {
            switch (i)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    drained = trckbr_VAS.Value;
                    break;
                case 3:
                    exhausted = trckbr_VAS.Value;
                    break;
                case 4:
                    overworked = trckbr_VAS.Value;
                    break;
                case 5:
                    spent = trckbr_VAS.Value;
                    break;
                case 6:
                    worn_out = trckbr_VAS.Value;
                    lack_of_energy = Math.Round((drained + exhausted + overworked + spent + worn_out) / 5);
                    break;
                case 7:
                    indifferent = trckbr_VAS.Value;
                    break;
                case 8:
                    inefficient = trckbr_VAS.Value;
                    break;
                case 9:
                    lack_of_initiative = trckbr_VAS.Value;
                    break;
                case 10:
                    listless = trckbr_VAS.Value;
                    break;
                case 11:
                    passive = trckbr_VAS.Value;
                    break;
                case 12:
                    responsiveness = trckbr_VAS.Value;
                    break;
                case 13:
                    uninterested = trckbr_VAS.Value;
                    break;
                case 14:
                    longing_to_lie_down = trckbr_VAS.Value;
                    reduced_motivation_and_activity = Math.Round((indifferent + inefficient + lack_of_initiative + listless + passive + responsiveness + uninterested + longing_to_lie_down) / 8);
                    break;
                case 15:
                    drowsy = trckbr_VAS.Value;
                    break;
                case 16:
                    fall_asleep = trckbr_VAS.Value;
                    break;
                case 17:
                    lazy = trckbr_VAS.Value;
                    break;
                case 18:
                    sleepy = trckbr_VAS.Value;
                    break;
                case 19:
                    vigilant = trckbr_VAS.Value;
                    break;
                case 20:
                    yawns = trckbr_VAS.Value;
                    sleepiness = Math.Round((drowsy + fall_asleep + lazy + sleepy + vigilant + yawns) / 6);
                    break;
                case 21:
                    clear_speech = trckbr_VAS.Value;
                    break;
                case 22:
                    forgetful = trckbr_VAS.Value;
                    break;
                case 23:
                    unconcentrated = trckbr_VAS.Value;
                    break;
                case 24:
                    unfocused = trckbr_VAS.Value;
                    reduced_mental_capacity = Math.Round((clear_speech + forgetful + unconcentrated + unfocused) / 4);
                    break;
                case 25:
                    aching = trckbr_VAS.Value;
                    break;
                case 26:
                    breathing_heavily = trckbr_VAS.Value;
                    break;
                case 27:
                    hurting = trckbr_VAS.Value;
                    break;
                case 28:
                    numbness = trckbr_VAS.Value;
                    break;
                case 29:
                    out_of_breath = trckbr_VAS.Value;
                    break;
                case 30:
                    palpitations = trckbr_VAS.Value;
                    break;
                case 31:
                    stiff_joints = trckbr_VAS.Value;
                    break;
                case 32:
                    sweaty = trckbr_VAS.Value;
                    break;
                case 33:
                    taste_of_blood = trckbr_VAS.Value;
                    break;
                case 34:
                    tense_muscles = trckbr_VAS.Value;
                    physical_exertion = Math.Round((aching + breathing_heavily + hurting + numbness + out_of_breath + palpitations + stiff_joints + sweaty + taste_of_blood + tense_muscles) / 10);
                    break;
                default: break;






            }
        }
        //series of properties to send valuables to other classes
        public double Aching
        {
            get
            {
                return aching;
            }
        }
        public double BreathingHeavily
        {
            get
            {
                return (breathing_heavily);
            }
        }
        public double ClearSpeech
        {
            get
            {
                return (clear_speech);
            }
        }
        public double Drained
        {
            get
            {
                return (drained);
            }
        }
        public double Drowsy
        {
            get
            {
                return (drowsy);
            }
        }
        public double Exhausted
        {
            get
            {
                return (exhausted);
            }
        }
        public double FallAsleep
        {
            get
            {
                return (fall_asleep);
            }
        }
        public double Forgetful
        {
            get
            {
                return (forgetful);
            }
        }
        public double Hurting
        {
            get
            {
                return (hurting);
            }
        }
        public double Indifferent
        {
            get
            {
                return (indifferent);
            }
        }
        //I'm very sure that's what this approach to exporting the values is
        public double Inefficient
        {
            get
            {
                return (inefficient);
            }
        }
        public double LackofInitiative
        {
            get
            {
                return (lack_of_initiative);
            }
        }
        public double Lazy
        {
            get
            {
                return (lazy);
            }
        }
        public double Listless
        {
            get
            {
                return (listless);
            }
        }
        public double Numbness
        {
            get
            {
                return (numbness);
            }
        }
        public double OutofBreath
        {
            get
            {
                return (out_of_breath);
            }
        }
        public double Overworked
        {
            get
            {
                return (overworked);
            }
        }
        public double Palpitations
        {
            get
            {
                return (palpitations);
            }
        }
        public double Passive
        {
            get
            {
                return (passive);
            }
        }
        public double Responsiveness
        {
            get
            {
                return (responsiveness);
            }
        }
        public double Sleepy
        {
            get
            {
                return (sleepy);
            }
        }
        public double Spent
        {
            get
            {
                return (spent);
            }
        }
        public double StiffJoints
        {
            get
            {
                return (stiff_joints);
            }
        }
        public double Sweaty
        {
            get
            {
                return (sweaty);
            }
        }
        public double TasteofBlood
        {
            get
            {
                return (taste_of_blood);
            }
        }
        public double TenseMuscles
        {
            get
            {
                return (tense_muscles);
            }
        }
        public double Unconcentrated
        {
            get
            {
                return (unconcentrated);
            }
        }
        public double Unfocused
        {
            get
            {
                return (unfocused);
            }
        }
        public double Uninterested
        {
            get
            {
                return (uninterested);
            }
        }
        public double Vigilant
        {
            get
            {
                return (vigilant);
            }
        }
        public double WornOut
        {
            get
            {
                return (worn_out);
            }
        }
        public double Yawns
        {
            get
            {
                return (yawns);
            }
        }
        public double LongingToLieDown
        {
            get
            {
                return (longing_to_lie_down);
            }
        }
        public double LackOfEnergy
        {
            get
            {
                return (lack_of_energy);
            }
        }
        public double ReducedMotivationAndActivity
        {
            get
            {
                return (reduced_motivation_and_activity);
            }
        }
        public double Sleepiness
        {
            get
            {
                return (sleepiness);
            }
        }
        public double ReducedMentalCapability
        {
            get
            {
                return (reduced_mental_capacity);
            }
        }
        public double PhysicalExertion
        {
            get
            {
                return (physical_exertion);
            }
        }
        //Method to change the appearance of the page and guide the user. Is called everytime i changes
        private void RefreshPage()
        {

            switch (i)
            {
                case 0:
                    btn_next.DialogResult = DialogResult.None;
                    btn_back.DialogResult = DialogResult.Cancel;
                    lbl_Text.Visible = true;
                    lbl_Text.Text = "Herzlich Willkommen!\nIm Folgenden werden Sie gebeten, Fragen zu Ihrem derzeitigen Zustand zu beantworten\nBitte seien Sie dabei möglichst aufrichtig und entscheiden Sie spontan.\nAm Ende erhalten Sie eine Übersicht zu Ihren Werten, \nanhand derer Sie Ihre Arbeit für den Tag fatigueoptimiert planen können.";
                    lbl_symptom.Visible = false;
                    lbl_agree.Visible = false;
                    lbl_disagree.Visible = false;
                    trckbr_VAS.Visible = false;
                    trckbr_VAS.Enabled = false;
                    progressBar1.Enabled = false;
                    progressBar1.Visible = false;
                    btn_back.Text = "Ende";
                    btn_next.Text = "Weiter";
                    break;
                case 1:
                    btn_back.DialogResult = DialogResult.None;
                    lbl_Text.Visible = true;
                    lbl_symptom.Visible = false;
                    lbl_agree.Visible = false;
                    lbl_disagree.Visible = false;
                    trckbr_VAS.Visible = false;
                    trckbr_VAS.Enabled = false;
                    progressBar1.Enabled = false;
                    progressBar1.Visible = false;
                    lbl_Text.Text = "Die Testung beginnt nun.\nBitte passen Sie den Schieberegler so an, \ndass er Ihre Empfindung zwischen den beiden Extremen wiederspiegelt.\nSie können den Schieberegler auch durch Klicken rechts bzw links des Reglers verschieben \noder die Pfeiltasten nutzen, um feinere Einstellungen vorzunehmen";
                    btn_back.Text = "Zurück";
                    break;
                case 2:
                    trckbr_VAS.Value = 250;
                    lbl_Text.Visible = false;
                    lbl_symptom.Visible = true;
                    lbl_symptom.Text = "Ich fühle mich ausgelaugt";
                    lbl_disagree.Visible = true;
                    lbl_agree.Visible = true;
                    lbl_disagree.Text = "trifft gar nicht zu";
                    lbl_agree.Text = "trifft voll zu";
                    trckbr_VAS.Visible = true;
                    trckbr_VAS.Enabled = true;
                    progressBar1.Visible = true;
                    progressBar1.Enabled = true;
                    progressBar1.Value = 1;
                    break;
                case 3:

                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich fühle mich erschöpft";
                    progressBar1.Value = 2;
                    break;
                case 4:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "ich fühle mich überarbeitet";
                    progressBar1.Value = 3;
                    break;
                case 5:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich fühle mich verausgabt";
                    progressBar1.Value = 4;
                    break;
                case 6:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich fühle mich schlapp";
                    progressBar1.Value = 5;
                    break;
                case 7:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Dingen begegne ich mit Gleichgültigkeit";
                    progressBar1.Value = 6;
                    break;
                case 8:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Meine Arbeit ist weniger Effizient als üblich.\nIch schaffe weniger am Tag";
                    progressBar1.Value = 7;
                    break;
                case 9:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Mir fällt es schwer(er), Eigeninitiativ zu handeln";
                    progressBar1.Value = 8;
                    break;
                case 10:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich fühle mich lustlos und unwillig, Dinge zu tun, die Aufwand erfordern";
                    progressBar1.Value = 9;
                    break;
                case 11:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich verhalte mich passiv";
                    progressBar1.Value = 10;
                    break;
                case 12:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich reagiere weniger/langsamer auf meine Umwelt";
                    progressBar1.Value = 11;
                    break;
                case 13:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich interessiere mich weniger für meine Umgebung/Dinge/Menschen";
                    progressBar1.Value = 12;
                    break;
                case 14:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich verspüre das Bedürfnis, mich hinzulegen";
                    progressBar1.Value = 13;
                    break;
                case 15:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich fühle mich verschlafen";
                    progressBar1.Value = 14;
                    break;
                case 16:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich kämpfe gegen den Schlaf an";
                    progressBar1.Value = 15;
                    break;
                case 17:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich fühle mich träge";
                    progressBar1.Value = 16;
                    break;
                case 18:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich fühle mich müde";
                    progressBar1.Value = 17;
                    break;
                case 19:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich habe Probleme dabei, wachsam zu bleiben";
                    progressBar1.Value = 18;
                    break;
                case 20:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich gähne häufig";
                    progressBar1.Value = 19;
                    break;
                case 21:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich verspreche mich häufiger oder habe Wortfindungsstörungen";
                    progressBar1.Value = 20;
                    break;
                case 22:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich bin vergesse leichter Dinge als üblich";
                    progressBar1.Value = 22;
                    break;
                case 23:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich bin unkonzentrierter als üblich";
                    progressBar1.Value = 23;
                    break;
                case 24:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich bin weniger fokussiert als üblich";
                    progressBar1.Value = 24;
                    break;
                case 25:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich spüre länger anhaltende Schmerzen";
                    progressBar1.Value = 25;
                    break;
                case 26:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich atme schwer";
                    progressBar1.Value = 26;
                    break;
                case 27:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Mir tut etwas bestimmtes weh";
                    progressBar1.Value = 27;
                    break;
                case 28:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich verspüre Taubheitsgefühle";
                    progressBar1.Value = 28;
                    break;
                case 29:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich bin schneller außer Atem als üblich";
                    progressBar1.Value = 29;
                    break;
                case 30:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich habe Herzklopfen";
                    progressBar1.Value = 30;
                    break;
                case 31:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich habe steife Glieder";
                    progressBar1.Value = 31;
                    break;
                case 32:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Ich schwitze schneller/stärker als normal";
                    progressBar1.Value = 32;
                    break;
                case 33:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Mein Mund schmeckt nach Blut";
                    progressBar1.Value = 33;
                    break;
                case 34:
                    trckbr_VAS.Value = 250;
                    lbl_symptom.Text = "Meine Muskeln sind verspannt";
                    progressBar1.Value = 34;
                    trckbr_VAS.Visible = true;
                    trckbr_VAS.Enabled = true;
                    lbl_symptom.Visible = true;
                    progressBar1.Visible = true;
                    lbl_agree.Visible = true;
                    lbl_disagree.Visible = true;
                    lbl_Text.Visible = false;
                    btn_next.Text = "Weiter";
                    btn_next.DialogResult = DialogResult.None;
                    break;
                case 35:
                    trckbr_VAS.Visible = false;
                    trckbr_VAS.Enabled = false;
                    lbl_symptom.Visible = false;
                    progressBar1.Visible = false;
                    lbl_agree.Visible = false;
                    lbl_disagree.Visible = false;
                    lbl_Text.Visible = true;
                    lbl_Text.Text = "Vielen Dank für Ihre Teilnahme! \nSie werden nun zum Hauptmenü zurückgeführt.\nDort haben Sie die Möglichkeit, sich das Ergebnis des Tests anzusehen\noder das Testergebnis zu exportieren";
                    btn_next.Text = "Beenden";
                    btn_next.DialogResult = DialogResult.OK;
                   
                    break;





                default:
                    break;

            }



        }

        private void Frm_assessment_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Frm_assessment_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }
    }




}

