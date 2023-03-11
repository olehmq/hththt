using System.Windows.Forms;
namespace MyLibsss
{
    public abstract class Music
    {
        public string Name { get; set; }

        public abstract void Correct();
        public abstract void InCorrect();
    }

    
    public class LucidDreams : Music
    {
        public override void Correct()
        {
            
            MessageBox.Show("Правильно");
        }

        public override void InCorrect()
        {
            MessageBox.Show("Не правильно");
        }
    }

    
    public class Witchblades : Music
    {
        public override void Correct()
        {
            MessageBox.Show("Правильно");
        }

        public override void InCorrect()
        {
            MessageBox.Show("Не правильно");
        }
    }

   
    public class BankAccount : Music
    {
        public override void Correct()
        {
            MessageBox.Show("Правильно ");
        }

        public override void InCorrect()
        {
            MessageBox.Show("Не правильно ");
        }
    }

   

    
}