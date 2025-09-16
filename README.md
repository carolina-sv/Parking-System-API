
# 🚗 Parking System API

**Parking System API** is a simple and efficient backend service to manage vehicle parking. Track vehicles, record entry and exit times, and calculate parking fees with ease.

---

## 🔹 Features

- Add and remove vehicles
- Track entry and exit timestamps
- Calculate parking fees automatically
- View all vehicles currently parked
- Simple REST API endpoints

---

## 🛠️ Technologies Used

- **C# / .NET 9** – Backend
- **GitHub** – Version control
- **Visual Studio** – Development IDE
- **UI Swagger** - Api endpoint

---

## ⚡ API Endpoints

| Endpoint               | Method | Description                     |
|------------------------|--------|---------------------------------|
| `/api/estacionamento`  | GET    | List all parked vehicles        |
| `/api/estacionamento/{plate}` | POST   | Add a new vehicle             |
| `/api/estacionamento/{plate}` | DELETE | Remove a vehicle and get fee  |

---

## 🚀 How to Run

1. Clone this repository:

```bash
git clone https://github.com/carolina-sv/Parking-System-API.git
````

2. Navigate to the project folder:

```bash
cd ParkingSystem/ParkingSystemApi
```

3. Restore dependencies and build:

```bash
dotnet restore
dotnet build
```

4. Run the API:

```bash
dotnet run
```

5. The API will be available at `http://localhost:5163`.

---

## 📝 Usage

You can test the API using **Postman** or any HTTP client:

* **GET** all vehicles: `http://localhost:5163/api/estacionamento`
* **POST** a vehicle: `http://localhost:5163/api/estacionamento/ABC1234`
* **DELETE** a vehicle: `http://localhost:5163/api/estacionamento/ABC1234`

---

## 💡 Contributing

Feel free to fork this repository and submit pull requests. Any contribution is welcome!

---

## 📜 License

This project is licensed under the MIT License.

```
