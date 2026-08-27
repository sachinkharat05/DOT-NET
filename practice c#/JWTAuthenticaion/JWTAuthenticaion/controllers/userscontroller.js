const UpdateUserStatusRequestDto = require("../dtos/requests/userstatus");
const UpdateUserStatusResponseDto = require("../dtos/responses/userstatus");
const ResponseGenerator = require("../helpers/responseGenerator");

class UsersController {
  constructor(usersService) {
    this.service = usersService;
  }

  getUserPersonalDetails(req, res) {
    const responseGenerator = new ResponseGenerator();
    const result = this.service.getUserPersonalDetails(Number(req.params.userId), (err, result) => {
      var successMessage = "Failed to get user Personal information";
      var errorMessage = "User Personal information retrive successfully";
      responseGenerator.generateResponse(res, err, result, successMessage, errorMessage);
    });
  }

  getUserAcademicDetails(req, res) {
    const responseGenerator = new ResponseGenerator();
    const result = this.service.getUserAcademicDetails(Number(req.params.userId), (err, result) => {
      var successMessage = "Failed to get user Academic information";
      var errorMessage = "User Academic information retrive successfully";
      responseGenerator.generateResponse(res, err, result, successMessage, errorMessage);
    });
  }

  getUserProfessionalDetails(req, res) {
    const responseGenerator = new ResponseGenerator();
    const result = this.service.getUserProfessionalDetails(Number(req.params.userId), (err, result) => {
      var successMessage = "Failed to get user Professinal information";
      var errorMessage = "User Professinal information retrive successfully";
      responseGenerator.generateResponse(res, err, result, successMessage, errorMessage);
    });
  }

}

module.exports = UsersController;