# 🌡️ Projeto Temperatura — Explicação Detalhada

## 📋 Descrição Geral

O projeto **Temperatura** é um aplicativo Windows Forms em C# para conversão de temperaturas entre Celsius e Fahrenheit. Ele foi desenvolvido aplicando princípios avançados de **Programação Orientada a Objetos (POO)**, com destaque para o uso de **herança**, **abstração**, **polimorfismo** e **interface**.

---

## 🏗️ Estrutura e Arquitetura

O projeto está organizado em camadas e utiliza abstração e interface para máxima flexibilidade:

```
Temperatura/
├── Form1.cs              # Interface gráfica (View)
├── modelo/
│   ├── AbsPropriedades.cs # Classe abstrata base (superclasse)
│   ├── IMetodos.cs        # Interface para métodos obrigatórios
│   ├── Controle.cs        # Controlador principal (Facade)
│   ├── Validacao.cs       # Validação de entrada (Model)
│   └── Conversao.cs       # Lógica de conversão de temperatura (Model)
```

---

## 🔄 Fluxo de Funcionamento

1. **Entrada do Usuário:** O usuário digita a temperatura e escolhe o tipo de conversão.
2. **Form1 (View):** Instancia a classe `Controle`, passando o valor e o tipo de conversão.
3. **Controle (Controller/Facade):** Herda de `AbsPropriedades`, executa a validação e, se válida, encaminha para a lógica de conversão.
4. **Validacao (Model):** Herda de `AbsPropriedades`, valida e converte a entrada para double.
5. **Conversao (Model):** Herda de `AbsPropriedades`, executa a conversão de temperatura.
6. **Retorno:** O resultado é exibido na interface.

---

## 🧩 Conceitos de Orientação a Objetos Aplicados

### 1. Herança e Abstração
- `AbsPropriedades` é uma **classe abstrata** que centraliza atributos e obriga a implementação do método `Executar()`.
- As classes `Controle`, `Validacao` e `Conversao` herdam de `AbsPropriedades`, evitando duplicação e promovendo generalização.

### 2. Interface
- `IMetodos` define o contrato para o método `Executar()`, garantindo que todas as classes derivadas implementem a lógica principal.

### 3. Encapsulamento
- Atributos protegidos e propriedades públicas controlam o acesso aos dados.
- Métodos internos como `Executar()` são sobrescritos e encapsulam a lógica de cada classe.

### 4. Construtores
- Cada classe derivada possui construtores específicos, garantindo inicialização correta e execução automática da lógica.

---

## 🧬 Polimorfismo — Detalhamento

O projeto **Temperatura** é um excelente exemplo de **polimorfismo** em POO:

- **Polimorfismo de Sobrescrita (Override):**
  - O método abstrato `Executar()` é declarado em `AbsPropriedades` e implementado de formas diferentes em `Controle`, `Validacao` e `Conversao`.
  - Cada classe executa sua lógica específica ao ser chamada por meio de uma referência da superclasse ou interface.

- **Exemplo prático:**
  ```csharp
  AbsPropriedades obj;
  obj = new Validacao("100");
  obj.Executar(); // Executa validação
  obj = new Conversao(100, "CF");
  obj.Executar(); // Executa conversão
  ```
  - O mesmo método (`Executar`) tem comportamentos diferentes dependendo do objeto instanciado.

- **Polimorfismo por Interface:**
  - Todas as classes derivadas implementam a interface `IMetodos`, podendo ser manipuladas por referências do tipo da interface.
  - Isso permite criar listas ou métodos que aceitam qualquer objeto que implemente `IMetodos`.

- **Benefícios do polimorfismo no projeto:**
  - **Flexibilidade:** Permite adicionar novas operações (ex: conversão para Kelvin) sem alterar o restante do sistema.
  - **Reutilização:** Métodos genéricos podem operar sobre diferentes tipos de conversão ou validação.
  - **Expansibilidade:** O sistema pode crescer sem perder organização.

---

## 🏢 Padrão Facade no Projeto

- A classe `Controle` atua como **Facade**, centralizando o acesso à validação e conversão, simplificando o uso pela interface gráfica.
- O formulário interage apenas com `Controle`, sem conhecer detalhes internos.

---

## 🧱 Princípios SOLID no Projeto

- **S — Responsabilidade Única:** Cada classe tem uma função clara (validação, conversão, controle).
- **O — Aberto/Fechado:** Novas conversões podem ser adicionadas sem modificar as classes existentes.
- **L — Substituição de Liskov:** Qualquer classe derivada de `AbsPropriedades` pode ser usada no lugar da superclasse.
- **I — Segregação de Interface:** A interface `IMetodos` é simples e específica.
- **D — Inversão de Dependência:** O controle do fluxo é feito por abstrações (superclasse e interface).

---

