﻿using System;

namespace FuncaoElevado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escreva dois valores, X e Y, para que receba o valor X^Y");
            double valorX = double.Parse(Console.ReadLine());
            double valorZ = double.Parse(Console.ReadLine());
            double valorXZ;
        
            switch (valorZ){
                case 0:
                {
                    valorXZ = 1;
                    Console.WriteLine($"X^Z = {valorXY}");
                    break;
                }
                
                case > 0:
                {
                    valorXZ = valorX;
                    for(int i = 2; i<=valorZ; i++)
                    {
                        if(valorZ==1)
                        {
                            valorXZ = valorX;
                            Console.WriteLine($"X^Z = {valorXZ}");
                            return;            
                        }
                        valorXZ *= valorX;
                    }
                    Console.WriteLine($"X^Z = {valorXZ}");
                    break;
                }
                
                case < 0:   
                {
                    valorXZ = 1d/valorX;
                    for(int i = -2; i>=valorZ; i--)
                    {
                        if(valorZ==-1)
                        {
                            valorXZ = 1d/valorX;
                            Console.WriteLine($"X^Z = {valorXZ}");
                            return; 
                        }
                        valorXZ *= 1d/valorX;
                    }
                    Console.WriteLine($"X^Z = {valorXZ}");
                    break;
                }
            }
        }
    }
}
