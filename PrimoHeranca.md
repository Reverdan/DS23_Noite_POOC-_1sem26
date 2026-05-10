# Projeto VerificaPrimoHerança — Explicação Detalhada

## Descrição Geral

O **VerificaPrimoHerança** é uma evolução do projeto VerificaPrimo, implementando o conceito de **herança** da Programação Orientada a Objetos (POO). O objetivo é demonstrar como a reutilização de código e a generalização de propriedades podem tornar o sistema mais flexível, organizado e preparado para futuras expansões.

---

## Estrutura e Arquitetura

O projeto está organizado em camadas, com destaque para a classe abstrata base:

```
VerificaPrimoHeranca/
├── Form1.cs              # Interface gráfica (View)
├── modelo/
│   ├── AbsPropriedades.cs # Classe abstrata base (superclasse)
│   ├── Controle.cs        # Controlador principal (Controller)
│   ├── Validacao.cs       # Validação de entrada (Model)
│   └── Primo.cs           # Lógica de verificação de número primo (Model)
```

---

## Fluxo de Funcionamento

1. **Entrada do Usuário:** O usuário digita um número e aciona a verificação.
2. **Form1 (View):** Instancia a classe `Controle`, passando o valor digitado.
3. **Controle (Controller):** Herda de `AbsPropriedades`, executa a validação e, se válida, encaminha para a lógica de verificação de primo.
4. **Validacao (Model):** Herda de `AbsPropriedades`, converte a string para inteiro e valida a entrada.
5. **Primo (Model):** Herda de `AbsPropriedades`, executa o algoritmo para determinar se é primo.
6. **Retorno:** A mensagem final é exibida na interface.

---

## Conceitos de Orientação a Objetos Aplicados

### 1. Herança
- A classe abstrata `AbsPropriedades` centraliza atributos e propriedades comuns (`Mensagem`, `Numero`, `N1`, `Num`).
- As classes `Controle`, `Validacao` e `Primo` herdam de `AbsPropriedades`, evitando duplicação de código e facilitando manutenção.

### 2. Abstração
- `AbsPropriedades` é uma **classe abstrata**: não pode ser instanciada diretamente, servindo apenas como base para outras classes.
- Define propriedades genéricas que podem ser utilizadas e especializadas pelas subclasses.

### 3. Encapsulamento
- Os atributos permanecem `private` na base, com acesso controlado por propriedades públicas (`get`/`set`).
- Métodos internos como `Validar()` e `Verificar()` continuam privados, protegendo a lógica interna.

### 4. Construtores e Polimorfismo
- Os construtores são utilizados para inicializar os objetos em estado válido.
- O polimorfismo é aplicado por meio da sobrescrita de métodos nas subclasses.

---

## Padrões de Projeto Utilizados

### Herança e Generalização
- O uso de uma superclasse abstrata (`AbsPropriedades`) é um padrão clássico para evitar repetição e promover a generalização de propriedades e métodos.

### MVC Simplificado
- O padrão de camadas é mantido:
  - **View:** `Form1`
  - **Controller:** `Controle`
  - **Model:** `Validacao` e `Primo`

### Facade
- O projeto VerificaPrimoHerança tambémb aplica o padrão de projeto **Facade**:

  - **O que é o Facade?**
    - O padrão Facade fornece uma interface simplificada para um subsistema complexo, centralizando o acesso e escondendo detalhes internos.

  - **Como é aplicado aqui?**
    - A classe `Controle` atua como um **Facade** para o subsistema de validação e verificação de primos.
    - O formulário (View) interage apenas com `Controle`, sem precisar conhecer a lógica de validação ou de verificação de primos.
    - `Controle` recebe a entrada, coordena a validação e a verificação, e retorna uma mensagem pronta para a interface.

  - **Benefícios do Facade no projeto:**
    - **Simplicidade:** O formulário lida com uma única classe, facilitando o uso e manutenção.
    - **Desacoplamento:** Mudanças internas em validação ou verificação não afetam a interface.
    - **Organização:** O fluxo de dados é centralizado, tornando o código mais limpo e compreensível.

---

## Algoritmo de Verificação de Primo

A lógica de verificação de número primo permanece eficiente e encapsulada na classe `Primo`, agora herdando as propriedades necessárias da superclasse.

---

## Benefícios da Arquitetura com Herança

- **Reutilização:** Propriedades comuns centralizadas em `AbsPropriedades`.
- **Facilidade de manutenção:** Alterações em propriedades comuns são feitas em um único lugar.
- **Expansibilidade:** Novas funcionalidades podem ser adicionadas por meio de novas subclasses.
- **Organização:** Código mais limpo, sem duplicidade de atributos e propriedades.

---

## Princípios SOLID no Projeto

O VerificaPrimoHerança tambémb demonstra a aplicação dos princípios **SOLID** da orientação a objetos:

- **S â€” Single Responsibility Principle (Responsabilidade Única):**
  - Cada classe tem uma responsabilidade bem definida: `Controle` coordena, `Validacao` valida, `Primo` verifica, e `AbsPropriedades` centraliza propriedades comuns.

- **O â€” Open/Closed Principle (Aberto/Fechado):**
  - As classes podem ser estendidas (herança), mas não precisam ser modificadas para novos comportamentos. Por exemplo, é possível criar novas validações ou verificações herdando de `AbsPropriedades`.

- **L â€” Liskov Substitution Principle (Substituição de Liskov):**
  - Qualquer classe derivada de `AbsPropriedades` pode ser usada no lugar da superclasse sem alterar o funcionamento do sistema.

- **I â€” Interface Segregation Principle (Segregação de Interface):**
  - O projeto utiliza propriedades e métodos específicos em cada classe, evitando interfaces grandes e genéricas. Cada classe expõe apenas o necessário.

- **D â€” Dependency Inversion Principle (Inversão de Dependência):**
  - O controle do fluxo é feito por abstrações (a superclasse), e não por implementações concretas. O formulário depende apenas de `Controle`, que abstrai o restante do sistema.

---



