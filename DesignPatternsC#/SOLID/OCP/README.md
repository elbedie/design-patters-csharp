# OCP — Open Closed Principle

## Definição

O princípio Aberto/Fechado (OCP) diz:

> Classes devem estar abertas para extensão, mas fechadas para modificação.

O objetivo é permitir a adição de novos comportamentos sem alterar código já existente.

---

## Problema

No exemplo abaixo, a classe precisa ser modificada sempre que um novo tipo de pagamento é criado.

```csharp
public class PaymentService
{
    public void ProcessPayment(string type)
    {
        if (type == "pix")
        {
            Console.WriteLine("Pagamento PIX");
        }
        else if (type == "creditcard")
        {
            Console.WriteLine("Pagamento cartão");
        }
    }
}
```

### Problemas dessa abordagem

- Alto acoplamento
- Crescimento excessivo de condicionais
- Necessidade de alterar código estável
- Maior risco de introduzir bugs

---

## Solução

Criar abstrações para permitir extensão sem modificar a lógica principal.

```txt
OCP/
├── Before/
│   └── PaymentService.cs
│
├── After/
│   ├── IPaymentMethod.cs
│   ├── PaymentMethod.cs
│   ├── PaymentService.cs
│   ├── PixPayment.cs
│   ├── CreditCardPayment.cs
│   └── BoletoPayment.cs
│
└── README.md
```

---

## Organização

| Classe | Responsabilidade |
|---|---|
| IPaymentMethod | Contrato de pagamento |
| PaymentMethod | Estrutura base compartilhada |
| PixPayment | Implementação PIX |
| CreditCardPayment | Implementação cartão |
| BoletoPayment | Implementação boleto |
| PaymentService | Processamento de pagamentos |

---

## Benefícios

- Facilidade para adicionar novos comportamentos
- Menor acoplamento
- Maior organização
- Código mais escalável
- Menor risco de regressão

---

## Conceito principal

OCP não significa:

> “Nunca modificar código”

O princípio significa:

> “Evitar modificar código estável para adicionar novas funcionalidades”