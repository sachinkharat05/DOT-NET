const express = require('express');
const authMiddleware = require("../middlewares/authMiddleware");


const UsersRoutes = (controller) => {
  const router = express.Router();

  router.get("/:userId/personal",authMiddleware,controller.getUserPersonalDetails.bind(controller));
  router.get("/:userId/academic", controller.getUserAcademicDetails.bind(controller));
  router.get("/:userId/professional", controller.getUserProfessionalDetails.bind(controller));
  
  return router;
};

module.exports = UsersRoutes;
