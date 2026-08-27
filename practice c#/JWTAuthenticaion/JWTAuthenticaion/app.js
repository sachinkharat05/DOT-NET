const express = require("express");
const cors = require("cors");
const bodyParser = require("body-parser");

const connection = require("./connectivity/db");

const AuthRepository = require("./repositories/authrepository");
const UsersRepository = require("./repositories/usersrepository");

const AuthService = require("./services/authservice");
const UsersService = require("./services/usersservices");

const UsersController = require("./controllers/userscontroller");
const AuthController = require("./controllers/authcontroller");

const AuthRoutes = require("./routers/authroutes");
const UsersRoutes = require("./routers/usersroutes");
const authMiddleware = require("./middlewares/authMiddleware");

const authRepository = new AuthRepository(connection);
const authService = new AuthService(authRepository);
const authController = new AuthController(authService);
const authRoutes = AuthRoutes(authController);

const usersRepository = new UsersRepository(connection);
const usersService = new UsersService(usersRepository);
const usersController = new UsersController(usersService);
const usersRoutes = UsersRoutes(usersController);
const app = express();

app.use(cors());
app.use(express.json());
app.use(bodyParser.json());
// app.use(authMiddleware);

app.use((req, res, next) => {
  console.log(`${req.method} ${req.originalUrl}`);
  next(); 
});

app.use("/api/auth/", authRoutes);
app.use("/api/users", usersRoutes);

module.exports = app;
