# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](img/02-mob-arch.png)

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

O diagrama de classes a seguir, adaptado para um ambiente de banco de dados NoSQL - onde a estrutura dos dados pode ser mais flexível e não segue necessariamente um esquema rígido como em bancos de dados SQL, apresenta a estrutura das entidades principais do sistema, incluindo Condomínio, Condomino, Reserva e Local.

1. Condomínio: Esta classe representa um condomínio e seus atributos básicos como Id (identificador único) e Nome. Além disso, possui coleções de Condominos, Locais e Reservas. Essas coleções podem ser consideradas como referências a documentos relacionados em um banco de dados NoSQL, onde não há uma estrutura de tabela fixa. Por exemplo, um condomínio pode ter uma lista de IDs de Condominos que pertencem a ele, uma lista de IDs de Locais disponíveis e uma lista de IDs de Reservas feitas neste condomínio.

2. Condomino: Esta classe representa um condômino e seus atributos básicos como Id e Nome. Da mesma forma que Condomínio, possui coleções de Condomínios (indicando os condomínios aos quais o condômino pertence) e Reservas (indicando as reservas feitas pelo condômino).

3. Reserva: Esta classe representa uma reserva de espaço em um condomínio. Ela possui atributos como Id, Data de Início e Data de Fim, e também faz referência ao condomínio onde a reserva foi feita, o condômino que fez a reserva e o local reservado. 

4. Local: Esta classe representa um espaço público dentro de um condomínio, como uma área de lazer. Possui atributos como Id e Descrição, que fornecem informações sobre o local.  

![Diagrama de Classes](img/diagrama_classes.png)

## Modelo ER

O modelo Entidade-Relacionamento (ER) proposto descreve a estrutura de um banco de dados NoSQL baseado em documentos, composto por quatro entidades principais: Condominio, Condomino, Local e Reserva. A entidade Condominio representa um condomínio ou complexo residencial, identificado por um atributo único, id, e possui um nome. Além disso, um Condominio pode possuir vários Condominos, Locais e Reservas.

![Modelo ER](img/diagrama_er.png)

A entidade Condomino representa um morador ou residente do condomínio, identificado por um atributo único, id, e possuindo um nome. Um Condomino pode estar associado a um ou mais Condominios, indicando os condomínios onde ele reside. Adicionalmente, um Condomino pode realizar várias Reservas de locais dentro do condomínio.

A entidade Local representa um espaço ou instalação dentro do condomínio que pode ser reservado, identificado por um atributo único, id, e possuindo um nome. Um Local pode ser parte de um ou mais Condominios e pode ser reservado em diferentes datas e horários por meio das Reservas. No modelo proposto, Local é uma subcoleção aninhada da coleçao Condominio.

A entidade Reserva representa a reserva de um Local por um Condomino em um determinado momento, identificada por um atributo único, idreserva. Uma Reserva está associada a um Condomino, indicando quem fez a reserva, a um Local, indicando o local reservado, e a uma data e hora específicas. Um Condomino pode ter zero ou mais Reservas de locais dentro do condomínio. No modelo proposto, Reserva é uma subcoleção aninhada das coleções Condominio e Condominos.

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
As referências abaixo irão auxiliá-lo na geração do artefato “Esquema Relacional”.

> - [Criando um modelo relacional - Documentação da IBM](https://www.ibm.com/docs/pt-br/cognos-analytics/10.2.2?topic=designer-creating-relational-model)

## Modelo Físico

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)

## Qualidade de Software

Conceituar qualidade de fato é uma tarefa complexa, mas ela pode ser vista como um método gerencial que através de procedimentos disseminados por toda a organização, busca garantir um produto final que satisfaça às expectativas dos stakeholders.

No contexto de desenvolvimento de software, qualidade pode ser entendida como um conjunto de características a serem satisfeitas, de modo que o produto de software atenda às necessidades de seus usuários. Entretanto, tal nível de satisfação nem sempre é alcançado de forma espontânea, devendo ser continuamente construído. Assim, a qualidade do produto depende fortemente do seu respectivo processo de desenvolvimento.

A norma internacional ISO/IEC 25010, que é uma atualização da ISO/IEC 9126, define oito características e 30 subcaracterísticas de qualidade para produtos de software.
Com base nessas características e nas respectivas sub-características, identifique as sub-características que sua equipe utilizará como base para nortear o desenvolvimento do projeto de software considerando-se alguns aspectos simples de qualidade. Justifique as subcaracterísticas escolhidas pelo time e elenque as métricas que permitirão a equipe avaliar os objetos de interesse.

> **Links Úteis**:
>
> - [ISO/IEC 25010:2011 - Systems and software engineering — Systems and software Quality Requirements and Evaluation (SQuaRE) — System and software quality models](https://www.iso.org/standard/35733.html/)
> - [Análise sobre a ISO 9126 – NBR 13596](https://www.tiespecialistas.com.br/analise-sobre-iso-9126-nbr-13596/)
> - [Qualidade de Software - Engenharia de Software 29](https://www.devmedia.com.br/qualidade-de-software-engenharia-de-software-29/18209/)
