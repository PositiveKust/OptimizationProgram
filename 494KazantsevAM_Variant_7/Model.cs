namespace _494KazantsevAM_Variant_7
{
    public class Model
    {
        public int id { get; set; }
        private string name, textoptimizationproblem, targertfuntion, modeloptimization, secondrestruction;
        private int sinssecondrestruction;
        private double maxminsecondrestr, lbvariableone, rbvariableone, lbvariabletwo, rbvariabletwo, accuracy;
        private bool flagminmaxextremumserch;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Textoptimizationproblem
        {
            get { return textoptimizationproblem; }
            set { textoptimizationproblem = value; }
        }
        public string Targertfuntion
        {
            get { return targertfuntion; }
            set { targertfuntion = value; }
        }
        public string Modeloptimization
        {
            get { return modeloptimization; }
            set { modeloptimization = value; }
        }
        public string Secondrestruction
        {
            get { return secondrestruction; }
            set { secondrestruction = value; }
        }
        public double Maxminsecondrestr
        {
            get { return maxminsecondrestr; }
            set { maxminsecondrestr = value; }
        }
        public double Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }
        public double Lbvariableone
        {
            get { return lbvariableone; }
            set { lbvariableone = value; }
        }
        public double Rbvariableone
        {
            get { return rbvariableone; }
            set { rbvariableone = value; }
        }
        public int Sinssecondrestruction
        {
            get { return sinssecondrestruction; }
            set { sinssecondrestruction = value; }
        }
        public bool Flagminmaxextremumserch
        {
            get { return flagminmaxextremumserch; }
            set { flagminmaxextremumserch = value; }
        }
        public double Lbvariabletwo
        {
            get { return lbvariabletwo; }
            set { lbvariabletwo = value; }
        }
        public double Rbvariabletwo
        {
            get { return rbvariabletwo; }
            set { rbvariabletwo = value; }
        }

        public Model() { }
        public Model(string name, string textoptimizationproblem, string targertfuntion,
            string modeloptimization, string secondrestruction, int sinssecondrestruction, double maxminsecondrestr,
            double lbvariableone, double rbvariableone, double lbvariabletwo, double rbvariabletwo, double accuracy,
            bool flagminmaxextremumserch)
        {
            this.name = name;
            this.textoptimizationproblem = textoptimizationproblem;
            this.targertfuntion = targertfuntion;
            this.modeloptimization = modeloptimization;
            this.secondrestruction = secondrestruction;
            this.sinssecondrestruction = sinssecondrestruction;
            this.maxminsecondrestr = maxminsecondrestr;
            this.lbvariableone = lbvariableone;
            this.rbvariableone = rbvariableone;
            this.lbvariabletwo = lbvariabletwo;
            this.rbvariabletwo = rbvariabletwo;
            this.accuracy = accuracy;
            this.flagminmaxextremumserch = flagminmaxextremumserch;
        }
    }
}
