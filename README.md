# DesignPatterns C#
Este projeto tem como objetivo mostrar os principais padrões de design utilizados.
## Design Patterns de criação
<details>
<summary>Factory Method</summary>
O Factory Method é design pattern do tipo criacional, que busca solucionar o problema de criação de objetos.
</details>

<details>
<summary>Abstract Factory</summary>
É um padrão de projeto do tipo criacional com o escopo na criação de objetos. Agrupa fábricas de objetos (várias factories) que estão relacionadas entre si. O Abstract Factory não possui a necessidade de especificar classes concretas, pois essa função está encapsulada nas Factories.
</details>

<details>
<summary>Singleton</summary>
O Singleton é um padrão de projeto do tipo criacional, que visa criar um objeto (uma instância de uma classe), e fornece um ponto global de acesso e essa instância e não permitindo que o mesmo objeto seja instanciado novamente (instância única).
</details>

<details>
<summary>Builder</summary>
O Builder é um padrão de projeto do tipo criacional, que possibilita separar a construção de partes de um objeto complexo de sua representação. Este padrão permite produzir diferentes tipos e representações de um objeto utilizando o mesmo código de construção.
</details>

## Design Patterns de estruturais
<details>
<summary>Adapter</summary>
É um padrão de projeto do tipo estrutural com o objetivo de adaptar interfaces distintas para atuarem em conjunto e gerando o resultado esperado.
  Ele ajuda a definir limites entre as camadas de uma aplicação de sacoplando códigos de terceiros, como frameworks e libs, e é utilizado também para adaptar código legado, o que diminui a depêndencia de tericeiros ou legado.
</details>

<details>
<summary>Prototype</summary>
É um padrão de projeto do tipo estrutural que possibilita a divisão de uma classe grande ou um conjunto de classes ligadas em dois grupos: Abstração e Implementação. Isso permite que os dois grupos sejam desenvolvidos de forma independente e o código cliente possa acessar apenas a parte de Abstração sem se preocupar com a parte de Implementação.
</details>
