Relatório de atividade | Projeto VR no Metaverso | Básico

***SEÇÃO 1 — IDENTIFICAÇÃO 
Nome Completo: Jéssica Yule
Turma / Residência: Trilha 1 - turma 5
Repositório do projeto: https://github.com/jessica-y-y/Metaverso

***SEÇÃO 2 — CONCEITO DO PROJETO 
2.1 Nome do Projeto: Yoga place - local de educação para aulas de Yoga

2.2 Contexto e Objetivo no Metaverso: 
Criar um ambiente educacional imersivo voltado ao bem estar e práticas de saúde, onde o usuário pode vivenciar uma aula de yoga em ambiente virtual. O ambiente resolve a barreira geográfica e financeira de acesso às práticas de saúde orientais, democratizando o aprendizado. No contexto do metaverso, funciona como um estúdio virtual acessível para qualquer pessoa. A evolução natural é obter parâmetros do usuário (através de câmera e microfone) para corrigir posturas e dar o feedback sobre a execução, se tornando o mais próximo de uma aula presencial com mestres experientes. 

2.3 Descrição Geral do Ambiente Virtual: 
Um local ao ar livre, com gramado verde, árvores ao redor e céu diurno claro. No centro da cena há um tapete de yoga para o player se posicionar. 
O gramado foi baixado da loja do Unity assets, mas os demais itens foram construídos com primitivos para manter o projeto leve sem deixar de testar os conteúdos demonstrados em aula.

***SEÇÃO 3 — CONFIGURAÇÃO TÉCNICA DO PROJETO 
3.1 Versão do Unity e Porquê: Unity 6000.3.9f1 LTS, por ser a versão estável com suporte de longo prazo recomendada para o Meta XR SDK.

3.2 Instalação do Meta XR SDK (Passo a Passo): 1. Acesso à loja do Unity e pesquisa de Meta XR All in one;  
2. Download e Importação para my assets no Unity; 3. No Unity: Window > Package Management > Package Manager > My Assets > Meta XR All in one SDK > Install (em seguida “fix all” em todos os erros críticos para Android e PC sinalizados em vermelho em Project setup tool -  opção disponível quando clica na seta em Meta XR Tools)

3.3 Configurações de Build para Android/Meta Quest: 
No Unity: File > Build Profiles >  Android > Switch Platform 

3.4 Configuração do XR Plugin Management: 
No Unity: Window > Package Management > Package Manager > Unity Registry > pesquisa por OpenXR Plug In > Install
(em seguida “fix al” todos os erros sinalizados em Project validation)
No Unity: File > Build Profiles > OpenXR > habilitar caixinha de Meta Quest à esquerda

3.5 Movimentação no PC (Editor): Download do Simulador Meta XR no site da meta para Windows > Instalação no PC

***SEÇÃO 4 — ASSETS E ELEMENTOS DA CENA 
ASSET 1 
Nome:  Chão gramado
Tipo: Material  
Origem: Asset Store (Gratuito) 
Função: Criar o fundo imersivo do ambiente. 

ASSET 2 
Nome: Tapete de Yoga
Tipo: Objeto 3D 
Origem: Primitivo Unity (plano com ajuste de proporção)
Função: Criar ambiente coerente

ASSET 3 
Nome: Árvore
Tipo: Objeto 3D
Origem: Primitvo Unity (cilindro marrom para trando e esfera com a mesma textura do gramado na copa)
Função: Criar ambiente coerente natureza

ASSET 4
Nome: Pedra decorativa
Tipo: Objeto 3D 
Origem: Primitivo Unity (esfera cinza)
Função: Criar ambiente coerente de natureza

ASSET 5
Nome: Animal (veado)
Tipo: Prefab importado 
Origem: Asset Store (Gratuito) 
Função: Criar ambiente coerente natureza
Na versão de recuperação esse item foi substituido por um Avatar feminino fitness (prefab importado da Asset Storfe do Unity, para simular a professora da aula). Foi adicionado também um menu para a escolha do tipo de aula - aula de Yoga ou de Pranayama). 
Na versão de recuperação foi mantida a interação de áudio ambiente com sons da natureza (implementado quando o player chega no tapete de yoga na versão avançada, com o script corretamente adicionado na recuperação).

***SEÇÃO 5 — HIERARQUIA DE GAME OBJECTS 
Scene: Yoga place 
Para o ambiente foi escolhido  um cenário de natureza com iluminação correspondente ao pôr do Sol 

A Hierarquia de objetos ficou organizada da seguinte maneira:
  Pastas principais: BuildingBlock, Directional Light, Global volum, 
  Ambiente (com subpastas: gramado, árvores, pedras, veado), Aula de Yoga (com subpasta "tapete de yoga")

***SEÇÃO 6 — REPOSITÓRIO GITHUB 
6.1 Nome do Repositório: https://github.com/jessica-y-y/Metaverso
6.2 Estrutura de Pastas: somente as recomendadas (Assets, Packages e Project Settings )
Existem 3 branches: main (atividade básica), atividade avançada e atividade avançada de recuperação.

***SEÇÃO 7 — REFLEXÃO FINAL 
7.1 Aprendizado:  foi a minha primeira experiência com o Unity, então tudo foi aprendido do zero. Com as orientações das aulas, foi possível entender e utilizar bem a plataforma e recursos. 

7.2 Dificuldades Previstas: A maior dificuldade, sem dúvida, foi a dificuldade técnica do computador disponível, que não permitiu o uso do Unity de forma fluída. Além disso, entender a câmera, pontos de vista e interações possíveis para desenvolver com a Meta foi desafiador.

7.3 Melhorias Futuras: O ideal é implementar painéis interativos que apresentam guias visuais de posturas de asana. A longo prazo, integraria avatares animados demonstrando as práticas.


