# O Modelo Relacional
## Escolher um Domínio de Aplicação
- Agenda de Contatos
## Entidades
- Pessoas
- Contatos
- Endereços
## Relações
- Pessoa tem vários contatos
- Endereço pode abrigar várias pessoas

## Modelo Lógico

```mermaid
erDiagram
    Pessoa {
        string Nome
        date DataNascimento
        int PosicaoAgenda
        string Sexo
    }
    Endereco {
        string Distrito
        string Rua
        string CodigoPostal
        string CodigoPostalComplemento
        string NumeroPorta
    }
    Contato {
        string Tipo
        string Telefone
    }
    Pessoa ||--o{ Contato : Possui
    Endereco ||--o{ Pessoa : Possui

```


## Modelo Físico

[Script - Modelo Físico](https://github.com/RumosProjetos/Acao74240/blob/main/AcessoADados/Aula01/AgendaContatos.sql)
