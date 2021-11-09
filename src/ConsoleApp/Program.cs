// See https://aka.ms/new-console-template for more information

using System;
using Solid.ConsoleApp.DIP.Refatorado;

Console.WriteLine("Hello, World!");


var botao = new Botao(new Lampada());
var botao2 = new Botao(new Televisao());
