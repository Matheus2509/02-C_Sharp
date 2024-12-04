Console.WriteLine("Olá, esse programa calcula os dias em meses e anos");
Console.WriteLine("Vamos começar? Digite a quantidades de dias");
double dias = Convert.ToInt32(Console.ReadLine());
double mês = 0;
double ano = 0;
double apoio =0;
double apoio2 =0;
double mês3 = 0;
double apoio3 =0;


for (double i = dias; i > 0; i--){
    apoio++;
    apoio2++;
    if(apoio == 30 && mês3 != 2){
        mês++;
        apoio-=30;
        dias-=30;
        mês3++;
        apoio3++;
        if(apoio3 == 5){
            dias--;
            apoio--;
            apoio3=0;
        }
    }
    else if(apoio == 31){
        mês++;
        apoio-=31;
        dias-=31;
        mês3=0;
    }

    if(apoio2 == 365){
        mês=0;
        ano++;
        apoio2 = 0;
    }
}

Console.WriteLine($"Esses dias no total são: {ano} anos {mês} meses e {dias} dias: ");