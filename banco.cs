using System; 
using System.Globalization; 


public class banco {
    public string? nome {get; set;} 
    public double salario; 
    public double dep;  
    public double saq;
    public int Id_conta;  
    public double[] dados;  
    
public double mud_sal(){
    Console.WriteLine("Digite seu saldo: "); 
    double sal = double.Parse(Console.ReadLine());
    salario = sal; 
    return salario; 
}
public double mud_id(){
    Console.WriteLine("Digite seu Id: "); 
    int ID = int.Parse(Console.ReadLine());
    Id_conta = ID; 
    return Id_conta; 
}
public string mud_nome(){
    Console.WriteLine("Digite seu nome: ");
    string name = Console.ReadLine();
    nome = name; 
    return nome; 
}
public double mu_dep(){
    Console.WriteLine("Digite o valor de deposito: "); 
    double depi = double.Parse(Console.ReadLine());
    dep = depi; 
    return salario + dep; 
}
public double mu_saq(){
    Console.WriteLine("Digite o valor do saque: "); 
    double seqi = double.Parse(Console.ReadLine());
    saq = seqi; 
    return salario - saq - 5; 
}

    public override string ToString()
    {
        Console.WriteLine("Dados da conta: ");
        return ("Nome: "+ nome+ ", "+"Seu ID: "+ Id_conta+ ", "+ "seu saldo: " + salario+".");  
    }


}
