const express = require("express");
const router = express.Router();

const controller = require("../controllers/assessments.controller");

router.get("/assessments", controller.getAssessments);

router.get( "/assessments/:assessmentId/questions",controller.getQuestions);

router.post("/submissions",controller.submitAnswer);

module.exports = router;