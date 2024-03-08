
using Cs_Interface_Bank_task_.Models;

Bank bank = new Bank("ABB",50000000,20000000);
CEO _CEO = new CEO("Taleh", "Aliyev", 30, "CEO", 5000);
bank.ceo = _CEO;
Console.WriteLine("CEO: "+bank.ceo.name);


//salam muellim,dersimiz interface idi deye her seyi interface-le qruplasdirib classlari bu interfacelerden implement etmisem amma kod tekrari cox olur abstract class istifade etsem daha az olardi