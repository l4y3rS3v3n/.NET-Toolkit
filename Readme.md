# **Service.Toolkit — Uma caixa de ferramentas prática para o dia a dia em .NET**

Este repositório nasce de uma necessidade real: depois de anos trabalhando com .NET em cenários distribuídos, alta carga, integrações financeiras, baixa latência e múltiplos serviços, percebi que meu fluxo de trabalho estava sempre esbarrando no mesmo problema — **refazer o básico**.

Coisas que não mudam, independente do produto, do time ou do domínio:

- Como estruturar corretamente cache local e distribuído
- Como aplicar resiliência de forma padronizada
- Como montar handlers, middlewares e policies de maneira consistente
- Como entender o comportamento interno de async/await
- Como o Kestrel, o thread pool e o IO do sistema operacional modelam a latência
- Como organizar configurações, boas práticas e convenções para um projeto saudável
- Como mitigar problemas recorrentes antes mesmo que apareçam
    

Para quem tem TDAH, como eu, isso não é apenas uma preferência.  
É **sobre liberar RAM mental**, evitando gastar energia tomando decisões repetidas, relembrando detalhes internos ou repensando a mesma solução cem vezes.

Esse toolkit é, portanto:

- **um guia prático**
- **um conjunto de padrões reutilizáveis**
- **um acervo de conhecimento acumulado**
- **uma referência para mim, para minha equipe e para qualquer dev .NET**
- **um template sólido para a IA gerar código no meu estilo**

Não é um “framework”.  
É uma **base**, construída aos poucos, dia após dia, consolidando o que realmente funciona no cotidiano de projetos .NET modernos.

Aqui você encontrará desde implementações de cache e resiliência até explicações sobre _por que usamos await_, o que realmente acontece lá embaixo (epoll/IOCP, scheduling, Kestrel), como rastrear falhas difíceis, como padronizar estruturas comuns e como criar um projeto sustentável.

Este repositório evolui continuamente — como um diário técnico modular — e serve como uma caixa de ferramentas que posso consultar sempre que necessário, sem depender de memória, sem reinventar peças e sem depender da IA para gerar tudo do zero.

A intenção é clara:

> **Construir uma fundação sólida, moderna e prática para projetos .NET, que reduz complexidade, elimina retrabalho e permite foco no que realmente importa: resolver o problema do negócio.**
