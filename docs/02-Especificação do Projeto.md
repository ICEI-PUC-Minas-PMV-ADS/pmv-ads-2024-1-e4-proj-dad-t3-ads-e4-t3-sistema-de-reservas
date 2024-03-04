# Especificações do Projeto

## Personas

> - `Carla Dias`
 - Moradora
 - Idade: 35 anos
 - Profissão: Advogada
 - Situação: Mãe de dois filhos pequenos
 - Necessidades: Procura agendar festas de aniversário e eventos familiares nos espaços comuns do condomínio de forma rápida e eficiente. Valoriza a segurança e a comodidade para seus filhos.

> - `João Neves`
 - Síndico
 - Idade: 50 anos
 - Profissão: Empresário
 - Situação: Síndico do condomínio há 5 anos
 - Necessidades: Precisa de uma ferramenta que simplifique o processo de gerenciamento de reservas e garanta a organização dos espaços comuns. Valoriza a facilidade de uso e a redução de conflitos entre os moradores.

`Maria Santos`
 - Idosa
 - Idade: 70 anos
 - Profissão: Aposentada
 - Situação: Vive sozinha no condomínio
 - Necessidades: Deseja reservar os espaços comuns para atividades recreativas e encontros sociais com outros moradores. Valoriza uma interface intuitiva e suporte acessível para tirar dúvidas durante o processo de reserva.

> - `Lucas Torres`
 - Estudante
 - Idade: 22 anos
 - Profissão: Estudante universitário
 - Situação: Morador temporário durante o período letivo
 - Necessidades: Busca espaços tranquilos para estudar e realizar reuniões de grupo. Valoriza a flexibilidade de horários e a facilidade de acesso às informações sobre disponibilidade dos espaços.

> - `Fernanda Silva`
- Profissional
- Idade: 40 anos
- Profissão: Executiva
- Situação: Viaja com frequência a trabalho
- Necessidades: Precisa reservar espaços para reuniões corporativas e eventos de networking quando está em casa. Valoriza a praticidade de agendamento e a integração com seu calendário profissional.

## Histórias de Usuários

Com base na análise das personas, foram identificadas as seguintes histórias de usuários:

|EU COMO...               | QUERO/PRECISO ...                                      |PARA ...                                           |
|-------------------------|--------------------------------------------------------|---------------------------------------------------|
|Carla Dias              | Visualizar a disponibilidade dos espaços comuns do condomínio | Poder agendar eventos e atividades de acordo com a minha conveniência |
|Carla Dias              | Reservar um espaço comum para um evento específico   | Garantir que o espaço esteja disponível para mim na data desejada |
|Carla Dias              | Receber notificações sobre a confirmação da minha reserva | Ter certeza de que minha reserva foi registrada com sucesso |
|João Neves              | Aprovar ou rejeitar reservas feitas pelos moradores | Garantir que as reservas estejam de acordo com as políticas do condomínio |
|João Neves              | Adicionar novos moradores ao sistema               | Garantir que todos os residentes tenham acesso à plataforma de reserva |
|João Neves              | Remover moradores do sistema                        | Manter a lista de usuários atualizada e segura |
|João Neves              | Modificar as permissões de acesso dos moradores     | Controlar quem pode fazer reservas e quem pode apenas visualizar a disponibilidade dos espaços |
|Maria Santos            | Visualizar a disponibilidade dos espaços comuns do condomínio | Poder agendar eventos e atividades de acordo com a minha conveniência |
|Maria Santos            | Reservar um espaço comum para um evento específico   | Garantir que o espaço esteja disponível para mim na data desejada |
|Maria Santos            | Receber notificações sobre a confirmação da minha reserva | Ter certeza de que minha reserva foi registrada com sucesso |
|Lucas Torres            | Visualizar a disponibilidade dos espaços comuns do condomínio | Poder agendar eventos e atividades de acordo com a minha conveniência |
|Lucas Torres            | Reservar um espaço comum para um evento específico   | Garantir que o espaço esteja disponível para mim na data desejada |
|Lucas Torres            | Receber notificações sobre a confirmação da minha reserva | Ter certeza de que minha reserva foi registrada com sucesso |
|Fernanda Silva          | Visualizar a disponibilidade dos espaços comuns do condomínio | Poder agendar eventos e atividades de acordo com a minha conveniência |
|Fernanda Silva          | Reservar um espaço comum para um evento específico   | Garantir que o espaço esteja disponível para mim na data desejada |
|Fernanda Silva          | Receber notificações sobre a confirmação da minha reserva | Ter certeza de que minha reserva foi registrada com sucesso |

Essas histórias de usuários serão fundamentais para orientar o desenvolvimento do sistema, garantindo que as necessidades e expectativas dos diferentes tipos de usuários sejam atendidas de maneira eficaz.


## Modelagem do Processo de Negócio 

### Análise da Situação Atual

Gestão Manual dos Espaços Comuns: Atualmente, a gestão dos espaços comuns do condomínio é feita de forma manual, geralmente por meio de agendas físicas ou planilhas compartilhadas. Isso pode levar a conflitos de agendamento, erros humanos e dificuldade na visualização da disponibilidade dos espaços.

Comunicação Ineficiente: A comunicação entre os moradores e a administração do condomínio em relação às reservas de espaços comuns é muitas vezes ineficiente. Os moradores podem enfrentar dificuldades para solicitar reservas, receber confirmações ou atualizações sobre suas reservas.

### Descrição Geral da Proposta

Automatização do Processo de Reservas: Implementação de um sistema online que permite aos moradores visualizarem a disponibilidade dos espaços comuns, fazerem reservas de forma autônoma e receberem confirmações automáticas.

Melhoria na Comunicação: Introdução de notificações automáticas para os moradores sobre o status de suas reservas, além de facilitar o contato com a administração do condomínio por meio de uma plataforma centralizada.


### Processo 1 – NOME DO PROCESSO

Apresente aqui o nome e as oportunidades de melhorias para o processo 1. Em seguida, apresente o modelo do processo 1, descrito no padrão BPMN. 

![Processo 1](img/02-bpmn-proc1.png)

### Processo 2 – NOME DO PROCESSO

Apresente aqui o nome e as oportunidades de melhorias para o processo 2. Em seguida, apresente o modelo do processo 2, descrito no padrão BPMN.

![Processo 2](img/02-bpmn-proc2.png)

## Indicadores de Desempenho

| Indicador                           | Objetivos                                      | Descrição                                                    | Fonte dos Dados          | Perspectiva    |
|-------------------------------------|------------------------------------------------|--------------------------------------------------------------|--------------------------|----------------|
| Taxa de Ocupação dos Espaços Comuns | Aumentar a utilização dos espaços comuns      | Porcentagem de tempo em que os espaços estão ocupados       | Sistema de Reservas      | Eficiência     |
| Tempo Médio de Resposta             | Melhorar a eficiência na gestão de reservas   | Tempo médio necessário para responder às solicitações       | Sistema de Reservas      | Eficiência     |
| Taxa de Reservas Canceladas         | Reduzir o número de reservas canceladas       | Porcentagem de reservas que são canceladas em relação ao total de reservas feitas | Sistema de Reservas      | Eficiência     |
| Nível de Satisfação dos Moradores   | Aumentar a satisfação dos moradores           | Avaliação dos moradores sobre a facilidade de uso e eficácia do sistema de reservas | Pesquisas de Satisfação | Satisfação     |
| Taxa de Utilização do Sistema       | Monitorar a adoção do sistema pelos moradores| Porcentagem de moradores que utilizam o sistema de reservas  | Sistema de Reservas      | Adoção         |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito                                                  | Prioridade |
|------|--------------------------------------------------------------------------|------------|
|RF-001| Permitir que o morador visualize a disponibilidade dos espaços comuns do condomínio | ALTA       |
|RF-002| Permitir que o morador reserve um espaço comum para um evento específico | ALTA       |
|RF-003| Enviar notificações para o morador sobre a confirmação da sua reserva    | MÉDIA      |
|RF-004| Permitir que o administrador do condomínio aprove ou rejeite as reservas feitas pelos moradores | ALTA       |
|RF-005| Permitir que o administrador do condomínio adicione novos moradores ao sistema | ALTA       |
|RF-006| Permitir que o administrador do condomínio remova moradores do sistema  | ALTA       |
|RF-007| Permitir que o administrador do condomínio modifique as permissões de acesso dos moradores | MÉDIA      |

### Requisitos não Funcionais

|ID     | Descrição do Requisito                                                  |Prioridade |
|-------|--------------------------------------------------------------------------|------------|
|RNF-001| O sistema deve ser responsivo para rodar em dispositivos móveis          | ALTA       |
|RNF-002| O sistema deve ser capaz de processar requisições do usuário em no máximo 3 segundos | ALTA       |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                                      |
|--|----------------------------------------------------------------|
|01| O sistema deve ser desenvolvido utilizando a linguagem Python   |
|02| O sistema deve ser implantado em um ambiente de nuvem pública   |
|03| O sistema deve cumprir os regulamentos de proteção de dados GDPR |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

# Matriz de Rastreabilidade

A matriz de rastreabilidade é uma ferramenta usada para facilitar a visualização dos relacionamento entre requisitos e outros artefatos ou objetos, permitindo a rastreabilidade entre os requisitos e os objetivos de negócio. 

A matriz deve contemplar todos os elementos relevantes que fazem parte do sistema, conforme a figura meramente ilustrativa apresentada a seguir.

![Exemplo de matriz de rastreabilidade](img/02-matriz-rastreabilidade.png)

> **Links Úteis**:
> - [Artigo Engenharia de Software 13 - Rastreabilidade](https://www.devmedia.com.br/artigo-engenharia-de-software-13-rastreabilidade/12822/)
> - [Verificação da rastreabilidade de requisitos usando a integração do IBM Rational RequisitePro e do IBM ClearQuest Test Manager](https://developer.ibm.com/br/tutorials/requirementstraceabilityverificationusingrrpandcctm/)
> - [IBM Engineering Lifecycle Optimization – Publishing](https://www.ibm.com/br-pt/products/engineering-lifecycle-optimization/publishing/)


# Gerenciamento de Projeto

De acordo com o PMBoK v6 as dez áreas que constituem os pilares para gerenciar projetos, e que caracterizam a multidisciplinaridade envolvida, são: Integração, Escopo, Cronograma (Tempo), Custos, Qualidade, Recursos, Comunicações, Riscos, Aquisições, Partes Interessadas. Para desenvolver projetos um profissional deve se preocupar em gerenciar todas essas dez áreas. Elas se complementam e se relacionam, de tal forma que não se deve apenas examinar uma área de forma estanque. É preciso considerar, por exemplo, que as áreas de Escopo, Cronograma e Custos estão muito relacionadas. Assim, se eu amplio o escopo de um projeto eu posso afetar seu cronograma e seus custos.

## Gerenciamento de Tempo

Com diagramas bem organizados que permitem gerenciar o tempo nos projetos, o gerente de projetos agenda e coordena tarefas dentro de um projeto para estimar o tempo necessário de conclusão.

![Diagrama de rede simplificado notação francesa (método francês)](img/02-diagrama-rede-simplificado.png)

O gráfico de Gantt ou diagrama de Gantt também é uma ferramenta visual utilizada para controlar e gerenciar o cronograma de atividades de um projeto. Com ele, é possível listar tudo que precisa ser feito para colocar o projeto em prática, dividir em atividades e estimar o tempo necessário para executá-las.

![Gráfico de Gantt](img/02-grafico-gantt.png)

## Gerenciamento de Equipe

O gerenciamento da equipe será realizado através da ferramenta de Gestão do  Projetos do Trello, onde após alinhado com os membros, serão registradas as tarefas a serem realizadas ao longo de cada sprint e para qual membro ela foi designada.

## Gestão de Orçamento

### Orçamento

| Recursos                 | Valor Estimado (em R$) |
|--------------------------|------------------------|
| Licenças de Software     | R$ 2.500               |
| Infraestrutura de Rede   | R$ 5.000               |
| Serviços de Hospedagem   | R$ 2.500               |
| Desenvolvedores          | R$ 25.000              |
| Testes de Qualidade      | R$ 7.500               |
| Suporte Técnico          | R$ 5.000               |
| Marketing e Publicidade  | R$ 7.500               |
| UX/UI                    | R$ 10.000              |
| Gestão de Pessoal/Tarefas| R$ 5.000               |
| Contingências            | R$ 5.000               |
| **Total**                | **R$ 70.000**          |

**Nota:** Os valores apresentados são estimativas e podem variar conforme a inclusão de novas funcionalidades, alterações nos requisitos do projeto ou condições do mercado.

