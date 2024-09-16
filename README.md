# API de Usuario e Feedback - Microservices

**RM98641 - Guilherme Henrique Almeida Jeronimo**  
**RM99959 - Gustavo Henrique Furtado Lourenço**  
**RM550806 - Iago Martins Carapiá Uttemberg**  
**RM550878 - Matheus da Costa Gonçalves**  
**RM99347 - Thomas Jeferson Santana Wang**

## Introdução

Na implementação de uma API para **Usuario** e **Feedback** com uma arquitetura de **microservices**, a decisão de usar essa abordagem envolve várias considerações, como a escalabilidade, modularidade e facilidade de manutenção da aplicação.

## Arquitetura da API: Microservices

### Por que escolhemos microservices?

1. **Escalabilidade Independente**  
   Cada microserviço pode ser escalado individualmente. Por exemplo, o serviço de **Usuario** pode ter maior demanda e, portanto, ser escalado sem a necessidade de aumentar a infraestrutura do serviço de **Feedback**.

2. **Desenvolvimento Modular**  
   Cada microserviço é uma aplicação isolada, permitindo que diferentes equipes trabalhem em paralelo nos serviços de **Usuario** e **Feedback**. Isso facilita a implantação e a manutenção, uma vez que o deploy de um microserviço não interfere no outro.

3. **Facilidade de Manutenção**  
   Com uma aplicação modular, fica mais simples testar, atualizar e corrigir erros em uma parte específica do sistema, sem impactar o restante.

4. **Isolamento de Falhas**  
   Se um serviço falha (por exemplo, o serviço de **Feedback**), ele não compromete o funcionamento dos demais serviços, como o de **Usuario**, garantindo maior robustez do sistema como um todo.

5. **Tecnologias e Escalabilidade Independente**  
   É possível escolher tecnologias e bancos de dados diferentes para cada serviço, caso necessário. Por exemplo, o serviço de **Feedback** pode usar uma tecnologia ou banco de dados otimizado para dados não-relacionais, enquanto o de **Usuario** pode permanecer com uma solução relacional.

## Diferenças entre uma API monolítica e microservices

### API Monolítica

- Todos os componentes (usuários, feedbacks, etc.) são desenvolvidos em uma única aplicação.
- Um único banco de dados e stack tecnológica para toda a aplicação.
- Implantação conjunta e dependente de toda a aplicação, mesmo que apenas um módulo tenha sido alterado.
- Dificuldade de escalar um único componente, forçando a escalabilidade do sistema como um todo.
- Em caso de falha de uma parte do sistema, toda a aplicação pode ficar indisponível.

### API Microservices

- Cada componente (por exemplo, **Usuario** e **Feedback**) é desenvolvido e implantado como uma aplicação independente.
- Cada serviço pode ter sua própria base de dados e tecnologias adequadas para suas necessidades específicas.
- Maior facilidade de escalabilidade e resiliência, pois os serviços podem ser escalados individualmente.
- Permite o uso de diferentes equipes, stacks tecnológicas e ciclos de desenvolvimento desacoplados para cada serviço.

---

## Instruções para rodar a API:

1. Fazer o **Download** do arquivo `.zip` no GitHub.
2. **Extrair** o projeto do arquivo `.zip`.
3. Abrir o **Visual Studio** e em seguida clicar em "abrir um projeto ou uma solução".
4. Abrir o projeto e clicar no arquivo `.sln`.
5. Apertar a tecla **F5** do teclado para executar o projeto.
