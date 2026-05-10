# ðŸŒ¡ï¸ Projeto Temperatura â€” ExplicaÃ§Ã£o Detalhada

## ðŸ“‹ DescriÃ§Ã£o Geral

O projeto **Temperatura** Ã© um aplicativo Windows Forms em C# para conversÃ£o de temperaturas entre Celsius e Fahrenheit. Ele foi desenvolvido aplicando princÃ­pios avanÃ§ados de **ProgramaÃ§Ã£o Orientada a Objetos (POO)**, com destaque para o uso de **heranÃ§a**, **abstraÃ§Ã£o**, **polimorfismo** e **interface**.

---

## ðŸ—ï¸ Estrutura e Arquitetura

O projeto estÃ¡ organizado em camadas e utiliza abstraÃ§Ã£o e interface para mÃ¡xima flexibilidade:

```
Temperatura/
â”œâ”€â”€ Form1.cs              # Interface grÃ¡fica (View)
â”œâ”€â”€ modelo/
â”‚   â”œâ”€â”€ AbsPropriedades.cs # Classe abstrata base (superclasse)
â”‚   â”œâ”€â”€ IMetodos.cs        # Interface para mÃ©todos obrigatÃ³rios
â”‚   â”œâ”€â”€ Controle.cs        # Controlador principal (Facade)
â”‚   â”œâ”€â”€ Validacao.cs       # ValidaÃ§Ã£o de entrada (Model)
â”‚   â””â”€â”€ Conversao.cs       # LÃ³gica de conversÃ£o de temperatura (Model)
```

---

## ðŸ”„ Fluxo de Funcionamento

1. **Entrada do UsuÃ¡rio:** O usuÃ¡rio digita a temperatura e escolhe o tipo de conversÃ£o.
2. **Form1 (View):** Instancia a classe `Controle`, passando o valor e o tipo de conversÃ£o.
3. **Controle (Controller/Facade):** Herda de `AbsPropriedades`, executa a validaÃ§Ã£o e, se vÃ¡lida, encaminha para a lÃ³gica de conversÃ£o.
4. **Validacao (Model):** Herda de `AbsPropriedades`, valida e converte a entrada para double.
5. **Conversao (Model):** Herda de `AbsPropriedades`, executa a conversÃ£o de temperatura.
6. **Retorno:** O resultado Ã© exibido na interface.

---

## ðŸ§© Conceitos de OrientaÃ§Ã£o a Objetos Aplicados

### 1. HeranÃ§a e AbstraÃ§Ã£o
- `AbsPropriedades` Ã© uma **classe abstrata** que centraliza atributos e obriga a implementaÃ§Ã£o do mÃ©todo `Executar()`.
- As classes `Controle`, `Validacao` e `Conversao` herdam de `AbsPropriedades`, evitando duplicaÃ§Ã£o e promovendo generalizaÃ§Ã£o.

### 2. Interface
- `IMetodos` define o contrato para o mÃ©todo `Executar()`, garantindo que todas as classes derivadas implementem a lÃ³gica principal.

### 3. Encapsulamento
- Atributos protegidos e propriedades pÃºblicas controlam o acesso aos dados.
- MÃ©todos internos como `Executar()` sÃ£o sobrescritos e encapsulam a lÃ³gica de cada classe.

### 4. Construtores
- Cada classe derivada possui construtores especÃ­ficos, garantindo inicializaÃ§Ã£o correta e execuÃ§Ã£o automÃ¡tica da lÃ³gica.

---

## ðŸ§¬ Polimorfismo â€” Detalhamento

O projeto **Temperatura** Ã© um excelente exemplo de **polimorfismo** em POO:

- **Polimorfismo de Sobrescrita (Override):**
  - O mÃ©todo abstrato `Executar()` Ã© declarado em `AbsPropriedades` e implementado de formas diferentes em `Controle`, `Validacao` e `Conversao`.
  - Cada classe executa sua lÃ³gica especÃ­fica ao ser chamada por meio de uma referÃªncia da superclasse ou interface.

- **Exemplo prÃ¡tico:**
  ```csharp
  AbsPropriedades obj;
  obj = new Validacao("100");
  obj.Executar(); // Executa validaÃ§Ã£o
  obj = new Conversao(100, "CF");
  obj.Executar(); // Executa conversÃ£o
  ```
  - O mesmo mÃ©todo (`Executar`) tem comportamentos diferentes dependendo do objeto instanciado.

- **Polimorfismo por Interface:**
  - Todas as classes derivadas implementam a interface `IMetodos`, podendo ser manipuladas por referÃªncias do tipo da interface.
  - Isso permite criar listas ou mÃ©todos que aceitam qualquer objeto que implemente `IMetodos`.

- **BenefÃ­cios do polimorfismo no projeto:**
  - **Flexibilidade:** Permite adicionar novas operaÃ§Ãµes (ex: conversÃ£o para Kelvin) sem alterar o restante do sistema.
  - **ReutilizaÃ§Ã£o:** MÃ©todos genÃ©ricos podem operar sobre diferentes tipos de conversÃ£o ou validaÃ§Ã£o.
  - **Expansibilidade:** O sistema pode crescer sem perder organizaÃ§Ã£o.

---

## ðŸ¢ PadrÃ£o Facade no Projeto

- A classe `Controle` atua como **Facade**, centralizando o acesso Ã  validaÃ§Ã£o e conversÃ£o, simplificando o uso pela interface grÃ¡fica.
- O formulÃ¡rio interage apenas com `Controle`, sem conhecer detalhes internos.

---

## ðŸ§± PrincÃ­pios SOLID no Projeto

- **S â€” Responsabilidade Ãšnica:** Cada classe tem uma funÃ§Ã£o clara (validaÃ§Ã£o, conversÃ£o, controle).
- **O â€” Aberto/Fechado:** Novas conversÃµes podem ser adicionadas sem modificar as classes existentes.
- **L â€” SubstituiÃ§Ã£o de Liskov:** Qualquer classe derivada de `AbsPropriedades` pode ser usada no lugar da superclasse.
- **I â€” SegregaÃ§Ã£o de Interface:** A interface `IMetodos` Ã© simples e especÃ­fica.
- **D â€” InversÃ£o de DependÃªncia:** O controle do fluxo Ã© feito por abstraÃ§Ãµes (superclasse e interface).

---


