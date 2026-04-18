# Desafio Projeto Hospedagem

## 📋 Descrição

Sistema de gerenciamento de reservas de hospedagem desenvolvido em C# utilizando o .NET. O projeto implementa uma solução para cadastro e controle de hóspedes, suites e reservas com funcionalidades de validação de capacidade e cálculo de valores com desconto.

## 🏗️ Estrutura do Projeto

```
Desafio-Projeto-Hospedagem/
├── Models/
│   ├── Pessoa.cs          # Classe que representa um hóspede
│   ├── Suite.cs           # Classe que representa uma suíte do hotel
│   └── Reserva.cs         # Classe que gerencia as reservas
├── Program.cs             # Ponto de entrada da aplicação
├── Hospedagem.csproj      # Arquivo de configuração do projeto
├── Desafio-Projeto-Hospedagem.sln  # Solução Visual Studio
├── .gitignore             # Arquivo de exclusão do Git
└── README.md              # Este arquivo

```

## 🎯 Funcionalidades

### 1. **Classe Pessoa**
Representa um hóspede do hotel com as seguintes características:

- **Propriedades:**
  - `Nome` (string): Nome do hóspede
  - `Sobrenome` (string): Sobrenome do hóspede

- **Construtores:**
  - `Pessoa(string nome)`: Cria uma pessoa com apenas o nome
  - `Pessoa(string nome, string sobrenome)`: Cria uma pessoa com nome e sobrenome completo

### 2. **Classe Suite**
Representa uma suíte disponível no hotel com as seguintes características:

- **Propriedades:**
  - `TipoSuite` (string): Tipo/categoria da suíte (ex: "Premium", "Deluxe")
  - `Capacidade` (int): Número máximo de hóspedes permitidos
  - `ValorDiaria` (decimal): Valor da diária em reais

- **Construtores:**
  - `Suite()`: Cria uma suíte vazia (padrão)
  - `Suite(string tipoSuite, int capacidade, decimal valorDiaria)`: Cria uma suíte com valores específicos

### 3. **Classe Reserva**
Gerencia as reservas de hospedagem com funcionalidades completas:

- **Propriedades:**
  - `Hospedes` (List<Pessoa>): Lista de hóspedes da reserva
  - `Suite` (Suite): Suite reservada
  - `DiasReservados` (int): Número de dias da reserva

- **Construtores:**
  - `Reserva()`: Cria uma reserva vazia
  - `Reserva(int diasReservados)`: Cria uma reserva com dias especificados

- **Métodos:**
  - `CadastrarSuite(Suite suite)`: Atribui uma suíte à reserva
  - `CadastrarHospedes(List<Pessoa> hospedes)`: Registra hóspedes com validação de capacidade
  - `ObterQuantidadeHospedes()`: Retorna o número total de hóspedes na reserva
  - `CalcularValorDiaria()`: Calcula o valor total com desconto de 10% para reservas com 10 ou mais dias

### 4. **Validações Implementadas**
- ✅ Verificação de capacidade: Impede o cadastro de hóspedes que excedam a capacidade da suíte
- ✅ Cálculo com desconto: Aplicação automática de desconto de 10% para reservas a partir de 10 dias
- ✅ Tratamento de exceções: Lança exceção quando limite de capacidade é excedido

## 🚀 Como Usar

### Exemplo de Uso (Program.cs)

```csharp
// Criar hóspedes
Pessoa pessoa1 = new Pessoa(nome: "Hospede1");
Pessoa pessoa2 = new Pessoa(nome: "Hospede2");
List<Pessoa> hospedes = new List<Pessoa> { pessoa1, pessoa2 };

// Criar suite
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Criar reserva
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Consultar informações
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");
```

## 💡 Exemplo de Cálculo

**Cenário 1: Reserva com menos de 10 dias**
- Suite Premium: R$ 30/dia
- Dias reservados: 5
- Valor total: 5 × 30 = **R$ 150,00**

**Cenário 2: Reserva com 10 ou mais dias**
- Suite Premium: R$ 30/dia
- Dias reservados: 10
- Valor bruto: 10 × 30 = R$ 300
- Desconto (10%): R$ 30
- Valor total: **R$ 270,00**

## 🛠️ Requisitos

- .NET Framework ou .NET Core
- Visual Studio ou Visual Studio Code
- C# 8.0 ou superior

## 📝 Notas

- O projeto segue o padrão orientado a objetos com encapsulamento através de properties
- As validações garantem a integridade dos dados de reserva
- O sistema de desconto incentiva reservas de longa duração