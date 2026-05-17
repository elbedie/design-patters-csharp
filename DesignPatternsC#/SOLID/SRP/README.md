# SRP — Single Responsibility Principle

## Definição

O princípio da Responsabilidade Única (SRP) diz:

> Uma classe deve ter apenas um motivo para mudar.

Cada classe deve possuir apenas uma responsabilidade dentro do sistema.

---

## Problema

Uma classe com múltiplas responsabilidades tende a:

- aumentar o acoplamento
- dificultar manutenção
- dificultar testes
- concentrar regras diferentes no mesmo lugar

Exemplo incorreto:

```csharp
public class UserService
{
    public void CreateUser(string name, string email)
    {
        // validação
        // persistência
        // envio de email
    }
}
```

---

## Solução

Separar responsabilidades em classes específicas.

```txt
SRP/
├── UserService.cs
├── UserValidator.cs
├── UserRepository.cs
└── EmailService.cs
```

| Classe | Responsabilidade |
|---|---|
| UserValidator | Validar dados |
| UserRepository | Salvar dados |
| EmailService | Enviar email |
| UserService | Coordenar fluxo |

---

## Benefícios

- Código mais organizado
- Menor acoplamento
- Facilidade de manutenção
- Facilidade de testes
- Maior reutilização

---

## Conceito principal

SRP não significa:

> “Uma classe deve ter apenas um método”

SRP significa:

> “Uma classe deve ter apenas um motivo para mudar”