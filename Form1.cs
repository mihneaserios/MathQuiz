using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathQuiz
{
    public partial class MathQuiz : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int quotient;
        int divisor;

        // These integer variables store the numbers 
        // for the addition inecuation. 
        int addend3;
        int addend4;

        // These integer variables store the numbers 
        // for the multiplication inecuation. 
        int multiplicand2;
        int multiplier2;

        // These integer variables store the numbers 
        // for the division inecuation. 
        int divisor2;
        int quotient2;

        // These integer variables store the numbers 
        // for the subtraction inecuation.
        int subtrahend2;
        int difference2;

        // These integer variables store the numbers 
        // for the multiplication ecuation. 
        int multiplicand3;
        int multiplier3;

        // These integer variables store the numbers 
        // for the division inecuation. 
        int divisor3;
        int quotient3;

        // These integer variables store the numbers 
        // for the addition inecuation. 
        int addend5;
        int addend6;

        // These integer variables store the numbers 
        // for the subtraction inecuation.
        int minuend3;
        int difference3;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int multiplicandofaddend1;
        int multiplierofaddend1;
        int newaddend2;

        // These integer variables store the numbers 
        // for the addition problem. 
        int newaddend1;
        int divisorofaddend2;
        int newsum;

        // These integer variables store the numbers 
        // for the multiplication problem.
        int addend1ofmultiplicand;
        int addend2ofmultiplicand;
        int newmultiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int newmultiplicand;
        int minuendofmultiplier;
        int subtrahendofmultiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int divisorofdividend;
        int newdivisor;
        int newquotient;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int anewminuend;
        int addend1ofsubtrahend;
        int anewdifference;

        // These integer variables store the numbers 
        // for the division problem. 
        int minuendofdivisor;
        int subtrahendofdivisor;
        int quotientwithdifference;

        // These integer variables store the numbers
        // for equality ecuation.
        int dvisorofequality;
        int multiplicandofequality;
        int multiplierofequality;

        // These integer variables store the numbers 
        // remaining time.
        int timeLeft;

        public Random GetRandomizer()
        {
            return randomizer;
        }

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz(Random randomizer)
        {
                // Fill in the addition problem.
                // Generate two random numbers to add.
                // Store the values in the variables 'addend1' and 'addend2'.
                addend1 = randomizer.Next(51);
                addend2 = randomizer.Next(51);

                // Convert the two randomly generated numbers
                // into strings so that they can be displayed
                // in the label controls.
                plusLeftLabel.Text = addend1.ToString();
                plusRightLabel.Text = addend2.ToString();

                // 'sum' is the name of the NumericUpDown control.
                // This step makes sure its value is zero before
                // adding any values to it.
                sum.Value = 0;

                // Fill in the subtraction problem.
                minuend = randomizer.Next(1, 101);
                subtrahend = randomizer.Next(1, minuend);
                minusLeftLabel.Text = minuend.ToString();
                minusRightLabel.Text = subtrahend.ToString();
                difference.Value = 0;

                // Fill in the multiplication problem.
                multiplicand = randomizer.Next(2, 11);
                multiplier = randomizer.Next(2, 11);
                timesLeftLabel.Text = multiplicand.ToString();
                timesRightLabel.Text = multiplier.ToString();
                product.Value = 0;

                // Fill in the division problem.
                divisor = randomizer.Next(2, 11);
                quotient = randomizer.Next(2, 11);
                dividedRightLabelinEquality.Text = divisor.ToString();
                dividedEqualityLabel.Text = quotient.ToString();
                dividedLeftLabelisUnknown.Value = 0;

                // Fill in the addition inecuation.
                addend4 = randomizer.Next(1, 101);
                addend3 = randomizer.Next(1, addend4);
                addendRightLabelBigger.Text = addend3.ToString();
                SmallerLabel.Text = addend4.ToString();
                addendLeftLabelUnknown.Value = 0;

                // Fill in the multiplication ecuation.
                multiplicand2 = randomizer.Next(2, 11);
                multiplier2 = randomizer.Next(2, 11);
                timesLeftLabelSmaller.Text = multiplicand2.ToString();
                timesRightLabelSmaller.Text = multiplier2.ToString();
                timesLabelBiggerUnknown.Value = 0;

                // Fill in the division ecuation.
                quotient2 = randomizer.Next(2, 11);
                divisor2 = randomizer.Next(2, 11);
                dividedRightLabelBigger.Text = divisor2.ToString();
                dividedSmallerLabel.Text = quotient2.ToString();
                dividedLeftLabelBiggerUnknown.Value = 0;

                // Fill in the subtraction ecuation.
                difference2 = randomizer.Next(51);
                subtrahend2 = randomizer.Next(51);
                BiggerLabel.Text = difference2.ToString();
                minusRightLabelSmaller.Text = subtrahend2.ToString();
                minusLeftLabelUnknown.Value = 0;

                // Fill in the multiplication ecuation.
                multiplier3 = randomizer.Next(2, 11);
                multiplicand3 = randomizer.Next(2, 11);
                timesLeftLabelinBigger.Text = multiplicand3.ToString();
                timesRightLabelBigger.Text = multiplier3.ToString();
                timesSmallerLabel.Value = 0;

                // Fill in the division inecuation.
                divisor3 = randomizer.Next(2, 11);
                quotient3 = randomizer.Next(2, 11);
                BiggerLabel2.Text = quotient3.ToString();
                dividedRightLabelSmaller.Text = divisor3.ToString();
                dividedLeftLabelUnknown.Value = 0;

                // Fill in the addition inecuation.
                addend5 = randomizer.Next(51);
                addend6 = randomizer.Next(51);
                plusLeftLabelBiggerorEqual.Text = addend5.ToString();
                SmallerorEqualLabel2.Text = addend6.ToString();
                plusRightLabelUnknown.Value = 0;

                // Fill in the subtraction inecuation.
                minuend3 = randomizer.Next(1, 101);
                difference3 = randomizer.Next(1, minuend3);
                minusLeftLabelSmallerorEqual.Text = minuend3.ToString();
                BiggerorEqual2.Text = difference3.ToString();
                minusRightLabelUnknown.Value = 0;

                // Fill in the subtraction problem.
                multiplicandofaddend1 = randomizer.Next(2, 11);
                multiplierofaddend1 = randomizer.Next(2, 11);
                newaddend2 = randomizer.Next(1, multiplicandofaddend1 * multiplierofaddend1);
                minusLefttimesLeftLabel.Text = multiplicandofaddend1.ToString();
                minusLefttimesRightLabel.Text = multiplierofaddend1.ToString();
                newminusRightLabel.Text = newaddend2.ToString();
                newdifference.Value = 0;

                // Fill in the addition problem..
                newsum = randomizer.Next(1, 101);
                newaddend1 = randomizer.Next(1, newsum);
                divisorofaddend2 = randomizer.Next(2, 11);

                // Convert the two randomly generated numbers
                // into strings so that they can be displayed
                // in the label controls.
                addendLeftLabel.Text = newaddend1.ToString();
                addendRighttimesRightLabel.Text = divisorofaddend2.ToString();
                addendwithdividedLabel.Text = newsum.ToString();

                // adding any values.
                addendRightdividedLeftLabelUnknown.Value = 0;

                // Fill in the multiplication problem.
                addend1ofmultiplicand = randomizer.Next(51);
                addend2ofmultiplicand = randomizer.Next(51);
                newmultiplier = randomizer.Next(2, 11);
                timesLeftplusLeftLabel.Text = addend1ofmultiplicand.ToString();
                timesLeftplusRightLabel.Text = addend2ofmultiplicand.ToString();
                newtimesRightLabel.Text = newmultiplier.ToString();
                newproduct.Value = 0;

                // Fill in the division problem.
                minuendofmultiplier = randomizer.Next(1, 101);
                subtrahendofmultiplier = randomizer.Next(1, minuendofmultiplier);
                newmultiplicand = randomizer.Next(2, 11);
                newtimesLestLabel.Text = newmultiplicand.ToString();
                timesRightminusLeftLabel.Text = minuendofmultiplier.ToString();
                timesRightminusRightLabel.Text = subtrahendofmultiplier.ToString();
                timeswithminusLabel.Value = 0;

                // Fill in the division problem.
                newdivisor = randomizer.Next(2, 11);
                newquotient = randomizer.Next(2, 11);
                divisorofdividend = randomizer.Next(2, 11);
                dividedLeftdividedRightLabel.Text = divisorofdividend.ToString();
                newdividedRightLabel.Text = newdivisor.ToString();
                dividedwithdivideLabel.Text = newquotient.ToString();
                dividedLeftdividedLeftLabelUnknown.Value = 0;

                //Fill in the subtraction problem.
                anewminuend = randomizer.Next(1, 101);
                anewdifference = randomizer.Next(1, anewminuend);
                addend1ofsubtrahend = randomizer.Next(1, anewminuend - anewdifference);
                newminusLeftLabel.Text = anewminuend.ToString();
                minusRightplusLeftLabel.Text = addend1ofsubtrahend.ToString();
                minusplusEqualLabel.Text = anewdifference.ToString();
                minusRightplusRightLabelUnknown.Value = 0;

                // Fill in the division problem.
                minuendofdivisor = randomizer.Next(1, 101);
                subtrahendofdivisor = randomizer.Next(1, minuendofdivisor);
                quotientwithdifference = randomizer.Next(2, 11);
                dividedLeftminusLeftLabel.Text = minuendofdivisor.ToString();
                dividedLeftminusRightLabel.Text = subtrahendofdivisor.ToString();
                dividedwithminusEqualLabel.Text = quotientwithdifference.ToString();
                newdividedRightLabelUnknown.Value = 0;

                //Fill in the equality ecuation.
                dvisorofequality = randomizer.Next(2, 11);
                multiplicandofequality = randomizer.Next(2, 11);
                multiplierofequality = randomizer.Next(2, 11);
                dividedRightLabelEqual.Text = dvisorofequality.ToString();
                timesLeftLabelEqual.Text = multiplicandofequality.ToString();
                timesRightLabelEqual.Text = multiplierofequality.ToString();
                dividedLeftLabelEqual.Value = 0;
          

                // Start the timer.
                timeLeft = 200;
                timeLabel.Text = "200 seconds";
                timer1.Start();

        }
        public MathQuiz()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz(GetRandomizer());
            startButton.Enabled = false;
        }

        /// <summary>
        /// Check the answers to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend - subtrahend == difference.Value) 
                && (multiplicand * multiplier == product.Value) 
                && (quotient * divisor == dividedLeftLabelisUnknown.Value) 
                && (addend4 - addend3 == addendLeftLabelUnknown.Value) 
                && (multiplicand2 * multiplier2 == timesLabelBiggerUnknown.Value) 
                && (divisor2 * quotient2 == dividedLeftLabelBiggerUnknown.Value) 
                && (difference2 + subtrahend2 == minusLeftLabelUnknown.Value) 
                && (multiplicand3 * multiplier3 == timesSmallerLabel.Value) 
                && (quotient3 * divisor3 == dividedLeftLabelUnknown.Value) 
                && (addend6 - addend5 == plusRightLabelUnknown.Value) 
                && (minuend3 - difference3 == minusRightLabelUnknown.Value) 
                && ((multiplicandofaddend1 * multiplierofaddend1) + newaddend2 == newdifference.Value) 
                && ((newsum - newaddend1) * divisorofaddend2 == addendRightdividedLeftLabelUnknown.Value) 
                && ((addend1ofmultiplicand + addend2ofmultiplicand) * newmultiplier == newproduct.Value) 
                && (newmultiplicand * (minuendofmultiplier - subtrahendofmultiplier) == timeswithminusLabel.Value) 
                && ((newquotient * newdivisor) * divisorofdividend == dividedLeftdividedLeftLabelUnknown.Value) 
                && ((anewminuend - anewdifference) - addend1ofsubtrahend == minusRightplusRightLabelUnknown.Value) 
                && (quotientwithdifference * (minuendofdivisor - subtrahendofdivisor) == newdividedRightLabelUnknown.Value) 
                && (dvisorofequality * multiplicandofequality * multiplierofequality == dividedLeftLabelEqual.Value))
                 return true;
            else
                return false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                dividedLeftLabelisUnknown.Value = divisor * quotient;
                addendLeftLabelUnknown.Value = addend4 - addend3;
                timesLabelBiggerUnknown.Value = multiplicand2 * multiplier2;
                dividedLeftLabelBiggerUnknown.Value = divisor2 * quotient2;
                minusLeftLabelUnknown.Value = difference2 + subtrahend2;
                timesSmallerLabel.Value = multiplicand3 * multiplier3;
                dividedLeftLabelUnknown.Value = divisor3 * quotient3;
                plusRightLabelUnknown.Value = addend6 - addend5;
                minusRightLabelUnknown.Value = minuend3 - difference3;
                newdifference.Value = (multiplicandofaddend1 * multiplierofaddend1) + newaddend2;
                addendRightdividedLeftLabelUnknown.Value = (newsum - newaddend1) * divisorofaddend2;
                newproduct.Value = (addend1ofmultiplicand + addend2ofmultiplicand) * newmultiplier;
                timeswithminusLabel.Value = newmultiplicand * (minuendofmultiplier - subtrahendofmultiplier);
                dividedLeftdividedLeftLabelUnknown.Value = (newquotient * newdivisor) * divisorofdividend;
                minusRightplusRightLabelUnknown.Value = (anewminuend - anewdifference) - addend1ofsubtrahend;
                newdividedRightLabelUnknown.Value = quotientwithdifference * (minuendofdivisor - subtrahendofdivisor);
                dividedLeftLabelEqual.Value = dvisorofequality * multiplicandofequality * multiplierofequality;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dividedLeftLabelisUnknown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }
    }
}
