using ScottPlot;
using SkiaSharp;

namespace BA_V1
{
    public partial class Frm_graphicalEvaluation : Form
    {

        double aching, breathing_heavily, clear_speech, drained, drowsy, exhausted, fall_asleep, forgetful, hurting, indifferent, inefficient, lack_of_initiative, lazy, listless, numbness,
            out_of_breath, overworked, palpitations, passive, responsiveness, sleepy, spent, stiff_joints, sweaty, taste_of_blood, tense_muscles, unconcentrated, unfocused, uninterested, vigilant, worn_out, yawns, longing_to_lie_down, lack_of_energy, reduced_motivation_and_activity,
            sleepiness, reduced_mental_capacity, physical_exertion;

        public Frm_graphicalEvaluation(double aching, double breathing_heavily, double clear_speech, double drained, double drowsy, double exhausted, double fall_asleep, double forgetful, double hurting, double indifferent, double inefficient, double lack_of_initiative,
            double lazy, double listless, double numbness, double out_of_breath, double overworked, double palpitations, double passive, double responsiveness, double sleepy, double spent, double stiff_joints, double sweaty, double taste_of_blood,
            double tense_muscles, double unconcentrated, double unfocused, double uninterested, double vigilant, double worn_out, double yawns, double longing_to_lie_down, double lack_of_energy, double reduced_motivation_and_activity, double sleepiness, double reduced_mental_capacity, double physical_exertion)
        {
            this.aching = aching;
            this.breathing_heavily = breathing_heavily;
            this.clear_speech = clear_speech;
            this.drained = drained;
            this.drowsy = drowsy;
            this.exhausted = exhausted;
            this.fall_asleep = fall_asleep;
            this.forgetful = forgetful;
            this.hurting = hurting;
            this.indifferent = indifferent;
            this.inefficient = inefficient;
            this.lack_of_initiative = lack_of_energy;
            this.lazy = lazy;
            this.listless = listless;
            this.numbness = numbness;
            this.out_of_breath = out_of_breath;
            this.overworked = overworked;
            this.palpitations = palpitations;
            this.passive = passive;
            this.responsiveness = responsiveness;
            this.sleepy = sleepy;
            this.spent = spent;
            this.stiff_joints = stiff_joints;
            this.sweaty = sweaty;
            this.taste_of_blood = taste_of_blood;
            this.tense_muscles = tense_muscles;
            this.unconcentrated = unconcentrated;
            this.unfocused = unfocused;
            this.uninterested = uninterested;
            this.vigilant = vigilant;
            this.worn_out = worn_out;
            this.yawns = yawns;
            this.longing_to_lie_down = longing_to_lie_down;
            this.lack_of_energy = lack_of_energy;
            this.reduced_motivation_and_activity = reduced_motivation_and_activity;
            this.sleepiness = sleepiness;
            this.reduced_mental_capacity = reduced_mental_capacity;
            this.physical_exertion = physical_exertion;
            InitializeComponent();
            showPlot();

        }

        private void Frm_graphicalEvaluation_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
        public void showPlot()

        {
           
            ScottPlot.Plot myPlot = new();
            ScottPlot.Palettes.Category20 palette = new();

            ScottPlot.Bar[] bars =
            {
                 new(){Position = 1, ValueBase=0, Value = lack_of_energy, FillColor = palette.GetColor(3)},
                 new(){Position = 2, ValueBase=0, Value = reduced_mental_capacity, FillColor = palette.GetColor(5)},
                 new(){Position = 3, ValueBase=0, Value = sleepiness, FillColor = palette.GetColor(6)},
                 new(){Position=4, ValueBase = 0, Value = reduced_mental_capacity, FillColor = palette.GetColor(7)},
                 new(){Position=5, ValueBase=0, Value = physical_exertion, FillColor = palette.GetColor(8)},

             };
            myPlot.Add.Bars(bars);

            Tick[] ticks =
            {
                 new Tick(1, "Lack of Energy"),
                 new Tick(2, "Reduced Motivation and activity"),
                  new Tick(3, "Sleepiness"),
                  new Tick(4, "Reduced Mental Capability"),
                  new Tick(5, "Physical Exertion"),
                 };

            myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            myPlot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;
            myPlot.Axes.Bottom.MajorTickStyle.Length = 5;
            myPlot.HideGrid();

            // tell the plot to autoscale with no padding beneath the bars
            myPlot.Axes.Margins(bottom: 0);
            myPlot.Axes.AutoScaleExpandX();
            myPlot.Axes.SetLimitsY(0, 5.5);
            // determine the width of the largest tick label
            float largestLabelWidth = 0;
            using SKPaint paint = new();
            foreach (Tick tick in ticks)
            {
                PixelSize size = myPlot.Axes.Bottom.TickLabelStyle.Measure(tick.Label, paint).Size;
                largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
            }

            // ensure axis panels do not get smaller than the largest label
            myPlot.Axes.Bottom.MinimumSize = largestLabelWidth;
            myPlot.Axes.Right.MinimumSize = largestLabelWidth;

            myPlot.SavePng("plot.bmp", 800, 500);
            myPlot.Clear();


            pictureBox1.Image = new Bitmap("plot.bmp") ;
            pictureBox1.Size = new Size(800, 500);

        }

        private void Frm_graphicalEvaluation_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Image.Dispose();
        }
    }
}

