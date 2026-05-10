# ðŸ“± Calculadora - AplicaÃ§Ã£o Windows Forms (.NET 8)

## ðŸ“‹ DescriÃ§Ã£o

AplicaÃ§Ã£o de calculadora desenvolvida em **C# .NET 8** utilizando **Windows Forms**, implementando conceitos fundamentais de **ProgramaÃ§Ã£o Orientada a Objetos (POO)** como responsabilidade Ãºnica, encapsulamento, propriedades e construtores.

---

## ðŸ—ï¸ Arquitetura do Projeto

O projeto estÃ¡ organizado em duas camadas principais:

```
Calculadora/
â”œâ”€â”€ apresentacao/
â”‚   â”œâ”€â”€ Form1.cs              # Interface grÃ¡fica (View)
â”‚   â”œâ”€â”€ Form1.Designer.cs     # ConfiguraÃ§Ã£o dos componentes visuais
â”‚   â””â”€â”€ Form1.resx            # Recursos do formulÃ¡rio
â””â”€â”€ modelo/
    â”œâ”€â”€ Controle.cs           # Controlador principal
    â”œâ”€â”€ Validacao.cs          # ValidaÃ§Ã£o de dados
    â””â”€â”€ Calculos.cs           # OperaÃ§Ãµes matemÃ¡ticas
```

---

## ðŸ”„ Fluxo de Dados do Programa

O fluxo de dados segue o padrÃ£o **MVC simplificado** (Model-View-Controller):

### Detalhamento do Fluxo:

1. **Entrada do UsuÃ¡rio**: O usuÃ¡rio digita dois nÃºmeros nos campos de texto e clica em um botÃ£o de operaÃ§Ã£o (+, -, *, /)
2. **Captura na View**: O `Form1` captura o evento de clique e chama o mÃ©todo `Executar()`
3. **CriaÃ§Ã£o do Controle**: Instancia a classe `Controle` passando os valores dos TextBoxes e a operaÃ§Ã£o
4. **ValidaÃ§Ã£o**: A classe `Controle` cria uma instÃ¢ncia de `Validacao` que:
   - Converte as strings em nÃºmeros double
   - Verifica divisÃ£o por zero
   - Captura exceÃ§Ãµes de conversÃ£o
5. **CÃ¡lculo**: Se a validaÃ§Ã£o for bem-sucedida, cria uma instÃ¢ncia de `Calculos` que executa a operaÃ§Ã£o
6. **Retorno**: O resultado (ou mensagem de erro) Ã© retornado para o `Form1` atravÃ©s da propriedade `Mensagem`
7. **ExibiÃ§Ã£o**: O `lblResultado` exibe o resultado final

---

## ðŸŽ¨ Componentes Visuais (Interface)

### **TextBox: `txbPrimeiroNumero`**
- **FunÃ§Ã£o**: Campo de entrada para o primeiro nÃºmero da operaÃ§Ã£o
- **LocalizaÃ§Ã£o**: Linha 1 do formulÃ¡rio
- **CaracterÃ­sticas**: Aceita entrada de texto que serÃ¡ validada e convertida para nÃºmero

### **TextBox: `txbSegundoNumero`**
- **FunÃ§Ã£o**: Campo de entrada para o segundo nÃºmero da operaÃ§Ã£o
- **LocalizaÃ§Ã£o**: Linha 2 do formulÃ¡rio
- **CaracterÃ­sticas**: Aceita entrada de texto que serÃ¡ validada e convertida para nÃºmero

### **Label: `lblPrimeiroNumero`**
- **FunÃ§Ã£o**: RÃ³tulo descritivo "Digite o primeiro nÃºmero"
- **LocalizaÃ§Ã£o**: Acima do primeiro TextBox
- **CaracterÃ­sticas**: OrientaÃ§Ã£o visual para o usuÃ¡rio

### **Label: `lblSegundoNumero`**
- **FunÃ§Ã£o**: RÃ³tulo descritivo "Digite o segundo nÃºmero"
- **LocalizaÃ§Ã£o**: Acima do segundo TextBox
- **CaracterÃ­sticas**: OrientaÃ§Ã£o visual para o usuÃ¡rio

### **Button: `btnSomar`**
- **FunÃ§Ã£o**: Executa a operaÃ§Ã£o de **adiÃ§Ã£o** (+)
- **Evento**: `btnSomar_Click` â†’ chama `Executar("+")`
- **LocalizaÃ§Ã£o**: Primeira linha de botÃµes (esquerda)

### **Button: `btnSubtrair`**
- **FunÃ§Ã£o**: Executa a operaÃ§Ã£o de **subtraÃ§Ã£o** (-)
- **Evento**: `btnSubtrair_Click` â†’ chama `Executar("-")`
- **LocalizaÃ§Ã£o**: Primeira linha de botÃµes (direita)

### **Button: `btnMultiplicar`**
- **FunÃ§Ã£o**: Executa a operaÃ§Ã£o de **multiplicaÃ§Ã£o** (*)
- **Evento**: `btnMultiplicar_Click` â†’ chama `Executar("*")`
- **LocalizaÃ§Ã£o**: Segunda linha de botÃµes (esquerda)

### **Button: `btnDividir`**
- **FunÃ§Ã£o**: Executa a operaÃ§Ã£o de **divisÃ£o** (/)
- **Evento**: `btnDividir_Click` â†’ chama `Executar("/")`
- **LocalizaÃ§Ã£o**: Segunda linha de botÃµes (direita)

### **Label: `lblResultado`**
- **FunÃ§Ã£o**: Exibe o resultado da operaÃ§Ã£o ou mensagens de erro
- **LocalizaÃ§Ã£o**: Parte inferior do formulÃ¡rio
- **CaracterÃ­sticas**: ConteÃºdo dinÃ¢mico atualizado apÃ³s cada operaÃ§Ã£o

---

## ðŸŽ¯ Conceito: Responsabilidade Ãšnica (SRP - Single Responsibility Principle)

O **PrincÃ­pio da Responsabilidade Ãšnica** estabelece que **cada classe deve ter uma Ãºnica responsabilidade** ou motivo para mudar. Este projeto aplica rigorosamente este conceito:

### **Classe `Form1` (ApresentaÃ§Ã£o)**
- **Responsabilidade**: Gerenciar a interface grÃ¡fica e eventos do usuÃ¡rio
- **NÃ£o faz**: ValidaÃ§Ã£o, cÃ¡lculos ou lÃ³gica de negÃ³cio
- **Apenas**: Captura entrada, delega processamento e exibe resultados

```csharp
// âœ… Responsabilidade Ãºnica: Interface com usuÃ¡rio
private void Executar(String op)
{
    Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, op);
    lblResultado.Text = controle.Mensagem;
}
```

### **Classe `Controle` (Controlador)**
- **Responsabilidade**: Coordenar o fluxo entre validaÃ§Ã£o e cÃ¡lculo
- **NÃ£o faz**: Interface, validaÃ§Ã£o de dados ou operaÃ§Ãµes matemÃ¡ticas
- **Apenas**: Orquestra as chamadas entre `Validacao` e `Calculos`

```csharp
// âœ… Responsabilidade Ãºnica: CoordenaÃ§Ã£o
private void Validar()
{
    Validacao validacao = new Validacao(num1, num2, op);
    if (validacao.Mensagem.Equals(""))
    {
        Calculos calculos = new Calculos(validacao.N1, validacao.N2, op);
        this.mensagem = calculos.Resultado.ToString();
    }
}
```

### **Classe `Validacao` (Modelo)**
- **Responsabilidade**: Validar e converter os dados de entrada
- **NÃ£o faz**: CÃ¡lculos ou interface
- **Apenas**: Converte strings para double, valida divisÃ£o por zero e trata exceÃ§Ãµes

```csharp
// âœ… Responsabilidade Ãºnica: ValidaÃ§Ã£o de dados
private void Validar()
{
    n1 = Convert.ToDouble(num1);
    n2 = Convert.ToDouble(num2);
    if (op.Equals("/") && n2 == 0.0)
        this.mensagem = "NÃ£o Ã© possÃ­vel dividir por zero.";
}
```

### **Classe `Calculos` (Modelo)**
- **Responsabilidade**: Executar operaÃ§Ãµes matemÃ¡ticas
- **NÃ£o faz**: ValidaÃ§Ã£o ou interface
- **Apenas**: Realiza as quatro operaÃ§Ãµes bÃ¡sicas

```csharp
// âœ… Responsabilidade Ãºnica: OperaÃ§Ãµes matemÃ¡ticas
private void Calcular()
{
    if (op.Equals("+")) resultado = n1 + n2;
    if (op.Equals("-")) resultado = n1 - n2;
    if (op.Equals("*")) resultado = n1 * n2;
    if (op.Equals("/")) resultado = n1 / n2;
}
```

### **BenefÃ­cios da Responsabilidade Ãšnica neste Projeto:**
âœ… **Manutenibilidade**: AlteraÃ§Ãµes em cÃ¡lculos nÃ£o afetam validaÃ§Ã£o  
âœ… **Testabilidade**: Cada classe pode ser testada isoladamente  
âœ… **Reusabilidade**: A classe `Calculos` pode ser usada em outros projetos  
âœ… **Clareza**: Fica evidente onde cada funcionalidade estÃ¡ implementada  

---

## ðŸ”’ Conceito: Encapsulamento

**Encapsulamento** Ã© o princÃ­pio de **ocultar detalhes internos** de uma classe e expor apenas o necessÃ¡rio atravÃ©s de uma interface controlada. Este projeto demonstra encapsulamento atravÃ©s de:

### **1. Atributos Private (Dados Internos Protegidos)**

```csharp
// âŒ NÃ£o acessÃ­vel fora da classe
private Double n1;
private Double n2;
private String op;
private Double resultado;
```

**Por que usar `private`?**
- Protege os dados de modificaÃ§Ãµes externas nÃ£o controladas
- Evita inconsistÃªncias (ex: alguÃ©m alterar `resultado` sem executar o cÃ¡lculo)
- Permite mudanÃ§as internas sem afetar cÃ³digo externo

### **2. Propriedades Public (Interface Controlada)**

```csharp
// âœ… Acesso controlado somente leitura
public Double Resultado
{
    get { return resultado; }
}
```

**CaracterÃ­sticas das Propriedades:**
- **Somente leitura** (`get` apenas): ExpÃµe dados sem permitir modificaÃ§Ã£o externa
- **ValidaÃ§Ã£o**: Pode incluir lÃ³gica de validaÃ§Ã£o no `set` (quando necessÃ¡rio)
- **Flexibilidade**: Permite mudar implementaÃ§Ã£o interna sem afetar cÃ³digo que usa a classe

### **3. MÃ©todos Private (LÃ³gica Interna Oculta)**

```csharp
// âŒ MÃ©todo privado: lÃ³gica interna
private void Calcular()
{
    if (op.Equals("+")) resultado = n1 + n2;
    // ...
}
```

**Por que mÃ©todos privados?**
- UsuÃ¡rios da classe nÃ£o precisam saber **como** o cÃ¡lculo Ã© feito
- Podem ser refatorados sem afetar cÃ³digo externo
- Reduzem a superfÃ­cie pÃºblica da classe

### **ComparaÃ§Ã£o: Com vs. Sem Encapsulamento**

#### âŒ **SEM Encapsulamento (MÃ¡ PrÃ¡tica)**
```csharp
public class CalculosMal
{
    public double n1;      // PÃºblico: pode ser alterado por qualquer cÃ³digo
    public double n2;
    public double resultado;
    
    // Qualquer cÃ³digo pode fazer:
    // calc.resultado = 999; // Resultado incorreto!
}
```

#### âœ… **COM Encapsulamento (Boa PrÃ¡tica)**
```csharp
public class Calculos
{
    private double n1;     // Privado: protegido
    private double n2;
    private double resultado;
    
    public Calculos(double n1, double n2, string op)
    {
        this.n1 = n1;
        this.n2 = n2;
        this.op = op;
        Calcular();        // Garante que resultado seja calculado
    }
    
    public double Resultado { get => resultado; } // Somente leitura
}
```

### **Exemplos de Encapsulamento no Projeto**

#### **Classe `Validacao`**
```csharp
private Double n1;           // âŒ NÃ£o acessÃ­vel externamente
private String mensagem;     // âŒ NÃ£o acessÃ­vel externamente

public double N1            // âœ… Acesso somente leitura
{
    get => n1;
}

public String Mensagem      // âœ… Acesso somente leitura
{
    get => mensagem;
}
```

**BenefÃ­cio**: Garante que `n1` e `mensagem` sÃ³ sejam definidos pela validaÃ§Ã£o interna, nÃ£o por cÃ³digo externo.

#### **Classe `Controle`**
```csharp
private String num1;         // âŒ Dados internos protegidos
private String num2;
private String op;
private String mensagem;

public Controle(String num1, String num2, String op)  // âœ… InicializaÃ§Ã£o controlada
{
    this.num1 = num1.Replace(".", ",");
    this.num2 = num2.Replace(".", ",");
    this.op = op;
    Validar();               // Processamento automÃ¡tico
}

public string Mensagem { get => mensagem; }  // âœ… Somente leitura
```

**BenefÃ­cio**: UsuÃ¡rios da classe nÃ£o podem criar um objeto `Controle` sem passar pelos processos de validaÃ§Ã£o e cÃ¡lculo.

### **Vantagens do Encapsulamento neste Projeto:**
âœ… **SeguranÃ§a**: Dados nÃ£o podem ser corrompidos externamente  
âœ… **ConsistÃªncia**: Estado interno sempre vÃ¡lido  
âœ… **ManutenÃ§Ã£o**: MudanÃ§as internas nÃ£o afetam cÃ³digo externo  
âœ… **Legibilidade**: Interface pÃºblica clara e simples  

---

## ðŸ—ï¸ Conceito: MÃ©todos Construtores

Um **construtor** Ã© um mÃ©todo especial que Ã© executado **automaticamente** quando um objeto Ã© criado. Ele **inicializa o estado** do objeto.

### **CaracterÃ­sticas dos Construtores**

```csharp
public class Calculos
{
    // Construtor: mesmo nome da classe, sem tipo de retorno
    public Calculos(double n1, double n2, string op)
    {
        this.n1 = n1;
        this.n2 = n2;
        this.op = op;
        Calcular();  // Executa cÃ¡lculo automaticamente
    }
}
```

**CaracterÃ­sticas:**
1. **Mesmo nome da classe**: `Calculos`
2. **Sem tipo de retorno**: Nem void
3. **Executado automaticamente**: Na criaÃ§Ã£o do objeto com `new`
4. **Inicializa atributos**: Define valores iniciais
5. **Pode chamar mÃ©todos**: Como `Calcular()`

### **Construtores no Projeto**

#### **1. Classe `Controle`**
```csharp
public Controle(String num1, String num2, String op)
{
    // Normaliza formato decimal
    this.num1 = num1.Replace(".", ",");
    this.num2 = num2.Replace(".", ",");
    this.op = op;
    
    // Inicia processo de validaÃ§Ã£o e cÃ¡lculo
    Validar();
}
```

**Responsabilidades:**
- âœ… Recebe os dados da interface
- âœ… Normaliza formato de nÃºmeros (ponto â†’ vÃ­rgula)
- âœ… Inicia automaticamente a validaÃ§Ã£o
- âœ… Garante que o objeto estÃ¡ pronto para uso

**Uso:**
```csharp
// Ao criar o objeto, tudo Ã© processado automaticamente
Controle controle = new Controle("10.5", "2.3", "+");
// ApÃ³s esta linha, controle.Mensagem jÃ¡ contÃ©m o resultado!
```

#### **2. Classe `Validacao`**
```csharp
public Validacao(String num1, String num2, String op)
{
    this.num1 = num1;
    this.num2 = num2;
    this.op = op;
    
    // Executa validaÃ§Ã£o automaticamente
    Validar();
}
```

**Responsabilidades:**
- âœ… Armazena os dados recebidos
- âœ… Executa validaÃ§Ã£o imediatamente
- âœ… Converte strings para double
- âœ… Define mensagens de erro se necessÃ¡rio

**Uso:**
```csharp
Validacao validacao = new Validacao("15", "3", "/");
// ApÃ³s esta linha, validacao.N1, validacao.N2 e validacao.Mensagem estÃ£o prontos
```

#### **3. Classe `Calculos`**
```csharp
public Calculos(double n1, double n2, string op)
{
    this.n1 = n1;
    this.n2 = n2;
    this.op = op;
    
    // Executa cÃ¡lculo automaticamente
    Calcular();
}
```

**Responsabilidades:**
- âœ… Recebe nÃºmeros jÃ¡ validados
- âœ… Executa a operaÃ§Ã£o matemÃ¡tica
- âœ… Armazena o resultado
- âœ… Garante que `Resultado` estÃ¡ disponÃ­vel imediatamente

**Uso:**
```csharp
Calculos calculos = new Calculos(10.0, 5.0, "*");
// ApÃ³s esta linha, calculos.Resultado jÃ¡ contÃ©m 50.0
```

### **Por que Usar Construtores?**

#### âŒ **SEM Construtor (MÃ¡ PrÃ¡tica)**
```csharp
public class CalculosMal
{
    public double n1;
    public double n2;
    public double resultado;
    
    public void Calcular()
    {
        resultado = n1 + n2;
    }
}

// Uso: mÃºltiplas etapas, propenso a erros
CalculosMal calc = new CalculosMal();
calc.n1 = 10;           // Pode esquecer de definir
calc.n2 = 5;            // Ordem pode ser confusa
calc.Calcular();        // Pode esquecer de chamar
double res = calc.resultado;  // Pode usar antes de calcular!
```

#### âœ… **COM Construtor (Boa PrÃ¡tica)**
```csharp
public class Calculos
{
    private double n1;
    private double n2;
    private double resultado;
    
    public Calculos(double n1, double n2, string op)
    {
        this.n1 = n1;
        this.n2 = n2;
        this.op = op;
        Calcular();  // Garante execuÃ§Ã£o
    }
    
    public double Resultado { get => resultado; }
}

// Uso: uma linha, sem erros
Calculos calc = new Calculos(10, 5, "+");
double res = calc.Resultado;  // Sempre vÃ¡lido!
```

### **Palavra-chave `this`**

Em todos os construtores do projeto, usamos `this`:

```csharp
public Calculos(double n1, double n2, string op)
{
    this.n1 = n1;   // this.n1 = atributo da classe
                     // n1 (direita) = parÃ¢metro do construtor
    this.n2 = n2;
    this.op = op;
}
```

**`this` serve para:**
- Diferenciar **atributos da classe** (`this.n1`) de **parÃ¢metros** (`n1`)
- Deixar claro que estamos acessando membros do objeto atual
- Evitar conflitos de nomes

### **Vantagens dos Construtores neste Projeto:**
âœ… **Garantia de InicializaÃ§Ã£o**: Objeto sempre criado em estado vÃ¡lido  
âœ… **Simplicidade**: Uma linha cria e processa o objeto  
âœ… **SeguranÃ§a**: ImpossÃ­vel usar objeto sem inicializar  
âœ… **Encadeamento**: Construtores chamam mÃ©todos que preparam o objeto  
âœ… **Imutabilidade**: Atributos private + construtor = dados protegidos  

---

## ðŸš€ Tecnologias Utilizadas

- **.NET 8** - Framework de desenvolvimento
- **C#** - Linguagem de programaÃ§Ã£o
- **Windows Forms** - Interface grÃ¡fica
- **Visual Studio 2022** - IDE

---

## ðŸ“¦ Como Executar

1. Clone o repositÃ³rio:
```bash
git clone https://github.com/Reverdan/DS23_Noite_POOC-_1sem26.git
```

2. Abra o projeto no Visual Studio 2022

3. Compile e execute (F5)

---

## ðŸ“š Conceitos de POO Aplicados

| Conceito | AplicaÃ§Ã£o no Projeto |
|----------|---------------------|
| **Responsabilidade Ãšnica** | Cada classe tem uma Ãºnica responsabilidade bem definida |
| **Encapsulamento** | Atributos private com propriedades public somente leitura |
| **Construtores** | InicializaÃ§Ã£o automÃ¡tica e execuÃ§Ã£o de lÃ³gica de inicializaÃ§Ã£o |
| **SeparaÃ§Ã£o de Camadas** | ApresentaÃ§Ã£o (View) separada do Modelo (Model) e Controle (Controller) |

---

## ðŸ‘¨â€ðŸ’» Autor

Desenvolvido como material didÃ¡tico para a disciplina de **ProgramaÃ§Ã£o Orientada a Objetos em C#** - **DS23 Noite - 1Âº Semestre 2026**

---

## ðŸ“„ LicenÃ§a

Este projeto Ã© de uso educacional.

