using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza queijodecorator = new QueijoDecorator(pizza);
            IPizza bacondecorator = new BaconDecorator(queijodecorator);
            IPizza ceboladecorator = new CebolaDecorator(bacondecorator);

            Console.WriteLine(ceboladecorator.BuscarTipoPizza());
            Console.WriteLine();
        }
    }
}

//O Decorator é um padrão de projeto estrutural que permite
//    que você acople novos comportamentos para objetos ao colocá-los dentro de
//    invólucros de objetos que contém os comportamentos.

//A herança é estática. Você não pode alterar o comportamento de um objeto existente durante o 
//    tempo de execução. Você só pode substituir todo o objeto por outro que foi criado de uma subclasse diferente.

//As subclasses só podem ter uma classe pai. Na maioria das linguagens, a herança 
//não permite que uma classe herde comportamentos de múltiplas classes ao mesmo tempo.