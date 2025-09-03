# DIO - Trilha .NET - Explorando a linguagem C#
[Meu perfil na DIO](https://www.dio.me/users/camilamattos_mila)  

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo **Explorando a linguagem C#**, da trilha **.NET da DIO**.

---

## 🚀 Minha Solução
Além das implementações solicitadas, eu também desenvolvi um **menu interativo** para facilitar a navegação no sistema.  
Isso permite cadastrar hóspedes, escolher suítes, realizar reservas e visualizar os resultados de forma mais prática.

---

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel.  
Será necessário utilizar:  

- **Classe Pessoa** → representa o hóspede  
- **Classe Suíte** → representa a suíte disponível no hotel  
- **Classe Reserva** → faz o relacionamento entre pessoa e suíte  

O programa deve calcular corretamente os valores dos métodos da classe Reserva, retornando a quantidade de hóspedes e o valor da diária, aplicando **10% de desconto** em caso de reservas acima de 10 dias.

---

## 📝 Regras e validações
1. Não deve ser possível realizar uma reserva em uma suíte com capacidade menor que a quantidade de hóspedes.  
   Exemplo: se a suíte comporta 2 pessoas, ao tentar reservar para 3 hóspedes deve ser lançada uma exception.  
2. O método **ObterQuantidadeHospedes** deve retornar a quantidade total de hóspedes.  
3. O método **CalcularValorDiaria** deve retornar o valor total (dias reservados x valor da diária).  
4. Reservas com **10 dias ou mais** devem receber um **desconto de 10%** no valor final.  

---

## 📊 Diagrama
![Diagrama de classe hotel](diagrama_classe_hotel.png)

---


