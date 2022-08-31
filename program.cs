using System;
using System.Globalization; 
namespace Program {
class program 
{ 
    static void Main (string[] args){
       
       banco b = new banco();
       b.mud_id();
       b.salario = b.mud_sal();
       b.mud_nome();
       b.salario =  b.mu_dep();
       b.salario =  b.mu_saq();
       Console.WriteLine(b.ToString()); 
       Console.WriteLine();


    }}}
