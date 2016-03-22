### HelloWorldGA

Este projeto apresenta um programa introdutório de algoritmo genético. Seu objetivo é mostrar como é possível 
descobrir uma frase com base apenas no tamanho da frase e em uma função que avalia a distância até a frase proposta. 

## Principais componentes do software

- [Program.cs](/HelloWorldGA/Program.cs) Programa inicial da Aplicação Windows.
- [Form1.cs](/HelloWorldGA/Form1.cs) Código principal do formulário, controla o Algoritom Genético 
- [Form1.Designer.cs](/HelloWorldGA/Form1.Designer.cs) Definir os aspectos gráficos do formulário
- [GASolver.cs](/HelloWorldGA/GASolver.cs) Controla o Algoritmo genético

## Exemplo da Interface do Programa

![](/imagem/HelloWorldGA.JPG)

## Uso do Programa

- TARGET - String com números sem acento, frase que o programa vai tentar descobrir.
- POPSIZE - (inteiro) tamanho da população de cada geração, default 1024.
- ELITRATE - (real<1.0) fração da população que é sobrevive para a próxima geração, default 0.1.
- MUTATIONRATE (real<1.0) fração da população que recebe uma mutação default = 0.25
- RunGA - botão que executa a solução

Na janela da solução mostra a evolução do elemento mais qualificado de cada geração e sua nota.
A menor nota é 0, que mostra que a distância entre a frase proposta e a descoberta é 0
