const express = require("express");
const cors = require("cors");

const app = express();

app.use(cors());
app.use(express.json());

const assessmentRoutes = require("./routes/assessments.routes");

app.use("/api", assessmentRoutes);

app.listen(5000, () => {
    console.log("Server running on port 5000");
});