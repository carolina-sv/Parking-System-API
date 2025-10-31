# 🚗 Parking System API

Parking System API é um serviço simples e eficiente para gerenciar o estacionamento de veículos.  
Com ele, é possível registrar entradas e saídas, acompanhar veículos estacionados e calcular automaticamente as tarifas de estacionamento.

---

## 🖥️ Interface

<img width="883" height="968" alt="InterfaceProject" src="https://github.com/user-attachments/assets/dd16cd46-a30c-40a2-b1ba-4a4dc75675d0" />

---

## 🔹 Funcionalidades

- Adicionar e remover veículos  
- Registrar horários de entrada e saída  
- Calcular automaticamente o valor do estacionamento  
- Visualizar todos os veículos atualmente estacionados  
- API REST simples e intuitiva  

---

## 🛠️ Tecnologias Utilizadas

- **C# / .NET 9** – Backend  
- **Swagger UI** – Interface para testar os endpoints da API  

---

## ⚡ Endpoints da API

| Endpoint                      | Método | Descrição                              |
|-------------------------------|--------|----------------------------------------|
| `/api/estacionamento`         | GET    | Lista todos os veículos estacionados   |
| `/api/estacionamento/{placa}` | POST   | Adiciona um novo veículo               |
| `/api/estacionamento/{placa}` | DELETE | Remove um veículo e calcula a tarifa   |

---

## 🚀 Como Executar o Projeto

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/carolina-sv/Parking-System-API.git
