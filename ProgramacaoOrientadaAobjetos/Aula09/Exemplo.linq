<Query Kind="Program" />

void Main()
{
	var numeros = new List<int>();
	for (int i = 0; i < 1000000; i++)
	{
		numeros.Add(i);
	}
	
	numeros.Count().Dump("Números dalista");
	
	var numerosPares = from n in numeros  where n % 2 == 0 select n;						
	numerosPares.Count().Dump("Numeros pares");
	
	var numerosParesComLambdaExpression = numeros.Where(n => n % 2 == 0).ToList();
	numerosParesComLambdaExpression.Count().Dump("Numeros pares lambda");
	
	

	var multiplosDe6 = from n in numeros where n % 2 == 0 && n % 3 == 0 select n;
	multiplosDe6.Count().Dump("Multiplos de 6");
	
	//Select top 10 from tabela
	multiplosDe6.Skip(10).Take(10).Dump("Multiplos de 6");


//apolices.where(x => x.datavencimento <= DAtetime.Now)

	/*
	select apolice.*
	from apolices
	where datavencimento <= Getdate()	
	*/


	/*
	select apolice.*
	from apolices
	where datavencimento <= Sysdate	
	*/

}

