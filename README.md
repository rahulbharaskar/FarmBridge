# FarmBridge

## Overview
This project consists of a **React.js frontend** and a **Spring Boot backend**. The frontend is built using Create React App, while the backend is a RESTful API developed using Spring Boot.

## Prerequisites
Before running the project, ensure you have the following installed:
- **Node.js** (Latest LTS version recommended)
- **npm** or **yarn**
- **Java 17 or later**
- **Maven** or **Gradle**
- **Spring Boot CLI** (Optional)

---

## Frontend (React.js)

### Available Scripts
Inside the `frontend` directory, you can run:

#### `npm install`
Installs all required dependencies.

#### `npm start`
Runs the app in development mode.
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.
The page reloads if you make edits, and you may see lint errors in the console.

#### `npm test`
Runs the test suite in interactive watch mode.

#### `npm run build`
Builds the app for production in the `build/` folder.

#### `npm run eject`
If you need full control over the configuration, you can eject. Note that this is irreversible.

### Configuration
Update the `.env` file in the `frontend` directory to set environment variables:
```
REACT_APP_API_URL=http://localhost:8080/api
```

### Learn More
For more details, visit the [React documentation](https://reactjs.org/).

---

## Backend (Spring Boot)

### Running the Backend
Inside the `backend` directory, you can run:

#### Using Maven
```sh
mvn spring-boot:run
```

#### Using Gradle
```sh
gradle bootRun
```

The backend will start at [http://localhost:8080](http://localhost:8080).

### REST API Endpoints
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET    | /api/users | Fetch all users |
| POST   | /api/users | Add a new user |
| PUT    | /api/users/{id} | Update a user by ID |
| DELETE | /api/users/{id} | Delete a user by ID |

### Configuration
Update `application.properties` in `src/main/resources/` to set backend configurations:
```
spring.datasource.url=jdbc:mysql://localhost:3306/mydb
spring.datasource.username=root
spring.datasource.password=yourpassword
```

### Building the Backend
Run the following command to build the Spring Boot application:
```sh
mvn clean package
```
This will generate a `jar` file inside the `target/` directory.

### Running the JAR file
```sh
java -jar target/backend-0.0.1-SNAPSHOT.jar
```

### Learn More
For more details, visit the [Spring Boot documentation](https://spring.io/projects/spring-boot).

---

## Deployment
### Frontend Deployment
You can deploy the React app to platforms like **Vercel**, **Netlify**, or **GitHub Pages**.

### Backend Deployment
The backend can be deployed to **Heroku**, **AWS**, **DigitalOcean**, or **any cloud server**.

---

## Troubleshooting
### `npm run build` fails to minify
Refer to the [React troubleshooting guide](https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify).

### Backend issues
Check if the database is running and accessible. If needed, use:
```sh
mvn clean spring-boot:run
```
for a fresh restart.

