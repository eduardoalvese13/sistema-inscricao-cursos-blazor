# Sistema de inscrição em cursos

Lista de exercícios 30 — UC UDWMJ.

Aplicação Blazor Web App com formulário de inscrição e validação de nome,
e-mail, idade e curso. O envio é simulado em dois segundos.

## Como executar

Com o SDK do .NET 10 instalado, execute na raiz do projeto.

```bash
dotnet watch run
```

Abra o endereço exibido no terminal e acesse `/inscricao`.

## Como testar

1. Clique em **Confirmar inscrição** sem preencher o formulário. Confira o
   resumo de validação e as mensagens junto aos campos.
2. Preencha o nome e escolha um curso. Informe um e-mail sem `@` e a idade
   `15`. Confira as mensagens de e-mail inválido e idade fora da faixa.
3. Corrija o e-mail para `aluna@example.com` e a idade para `20`. Confirme
   que o botão fica desabilitado com o texto **Processando...** e que a
   confirmação aparece depois de aproximadamente dois segundos.
