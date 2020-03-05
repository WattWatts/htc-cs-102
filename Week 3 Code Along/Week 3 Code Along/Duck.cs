using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_code_along
{
    class Goose
    {
        public string Name;
        public int Age;
        public int attackDamage;

        public void Honk()
        {
            MessageBox.Show("Kill god I mean honk, my name is " + Name + ". I am " + Age + " honks old.");
        }

        public void Aquack()
        {
            MessageBox.Show("I attack you for " + attackDamage + " damage");
        }
    }
}
