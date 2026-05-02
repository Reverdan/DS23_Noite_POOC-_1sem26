# 🧮 Projeto VerificaPrimo — Explicação Detalhada

## 📋 Descrição Geral

O **VerificaPrimo** é um aplicativo Windows Forms em C# que permite ao usuário informar um número e verificar se ele é primo. O projeto foi desenvolvido aplicando princípios sólidos de **Programação Orientada a Objetos (POO)**, com separação clara de responsabilidades e uso de padrões de projeto para garantir código limpo, reutilizável e de fácil manutenção.

---

## 🏗️ Estrutura e Arquitetura

O projeto está organizado em camadas, separando a interface gráfica (Form1) da lógica de negócio (modelo):

```
VerificaPrimo/
├── Form1.cs              # Interface gráfica (View)
├── modelo/
│   ├── Controle.cs       # Controlador principal (Controller)
│   ├── Validacao.cs      # Validação de entrada (Model)
│   └── Primo.cs          # Lógica de verificação de número primo (Model)
```

---

## 🔄 Fluxo de Funcionamento

1. **Entrada do Usuário:** O usuário digita um número e clica em "Verificar".
2. **Form1 (View):** Captura o evento de clique e instancia a classe `Controle`, passando o valor digitado.
3. **Controle (Controller):** Recebe o número, executa a validação e, se válida, encaminha para a lógica de verificação de primo.
4. **Validacao (Model):** Converte a string para inteiro e verifica se a entrada é válida.
5. **Primo (Model):** Recebe o número validado e executa o algoritmo para determinar se é primo.
6. **Retorno:** A mensagem final (primo ou não primo, ou erro) é exibida na interface.

---

## 🧩 Conceitos de Orientação a Objetos Aplicados

### 1. Responsabilidade Única (SRP)
- **Form1:** Responsável apenas pela interface e interação com o usuário.
- **Controle:** Orquestra o fluxo entre validação e verificação de primo.
- **Validacao:** Responsável exclusivamente por validar e converter a entrada.
- **Primo:** Contém apenas a lógica de verificação de número primo.

### 2. Encapsulamento
- Todos os atributos das classes são `private`, expondo apenas propriedades de leitura (`get`) para acesso externo.
- Métodos internos como `Validar()` e `Verificar()` são privados, protegendo a lógica interna e evitando manipulação indevida.

### 3. Construtores
- Todas as classes de modelo (`Controle`, `Validacao`, `Primo`) utilizam construtores para garantir que o objeto já seja criado em estado válido e pronto para uso, executando automaticamente os métodos necessários.

### 4. Propriedades
- O acesso aos resultados e mensagens é feito por meio de propriedades públicas somente leitura, garantindo segurança e consistência dos dados.

---

## 🏛️ Padrões de Projeto Utilizados

### MVC Simplificado
- O projeto segue um padrão **MVC simplificado**:
  - **View:** `Form1` (interface gráfica)
  - **Controller:** `Controle` (coordenação do fluxo)
  - **Model:** `Validacao` e `Primo` (lógica de negócio)

### Encapsulamento e Delegação
- O Controller delega responsabilidades para as classes de validação e lógica de negócio, promovendo baixo acoplamento e alta coesão.

---

## 🧠 Algoritmo de Verificação de Primo

A classe `Primo` implementa um algoritmo eficiente:
- Números menores ou iguais a 1 não são primos.
- 2 é primo.
- Números pares maiores que 2 não são primos.
- Para ímpares, verifica divisores de 3 até a raiz quadrada do número, otimizando o desempenho.

---

## 🚀 Benefícios da Arquitetura

- **Manutenção facilitada:** Alterações em validação ou lógica de primo não afetam a interface.
- **Reutilização:** As classes de validação e verificação podem ser usadas em outros projetos.
- **Testabilidade:** Cada classe pode ser testada isoladamente.
- **Clareza:** O fluxo de dados e responsabilidades é transparente.

---

