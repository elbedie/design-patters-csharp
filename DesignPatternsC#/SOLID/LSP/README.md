# LSP — Liskov Substitution Principle

## Definição

O princípio da Substituição de Liskov (LSP) diz:

> Objetos derivados devem poder substituir objetos da classe base sem alterar o comportamento esperado do sistema.

O objetivo é garantir que heranças mantenham comportamentos consistentes.

---

## Problema

No exemplo abaixo, a classe `Intern` herda de `Employee`, mas não consegue executar corretamente o comportamento esperado.

```csharp
public class Employee
{
    public virtual void CalculateBonus()
    {
        Console.WriteLine("Bônus calculado");
    }
}

public class Intern : Employee
{
    public override void CalculateBonus()
    {
        throw new Exception("Estagiário não recebe bônus");
    }
}
```

### Problemas dessa abordagem

- A subclasse quebra o comportamento esperado
- O sistema perde previsibilidade
- A herança foi modelada incorretamente

---

## Solução

Separar responsabilidades e especializações corretamente.

```txt
LSP/
├── Before/
│   ├── Employee.cs
│   ├── Intern.cs
│   └── Program.cs
│
├── After/
│   ├── Employee.cs
│   ├── BonusEmployee.cs
│   ├── Manager.cs
│   ├── Intern.cs
│   └── Program.cs
│
└── README.md
```

---

## Organização

| Classe | Responsabilidade |
|---|---|
| Employee | Funcionário genérico |
| BonusEmployee | Funcionários que recebem bônus |
| Manager | Funcionário com bônus |
| Intern | Funcionário sem bônus |

---

## Benefícios

- Heranças mais corretas
- Melhor modelagem de domínio
- Menor risco de erros inesperados
- Código mais previsível
- Menor necessidade de validações extras

---

## Conceito principal

LSP não significa:

> “Toda herança faz sentido”

O princípio significa:

> “Subclasses devem respeitar o comportamento esperado da classe base”