

class UsersServices {
  constructor(usersRepository) {
    this.repository = usersRepository;
  }
  
  getUserPersonalDetails(userId, callback) {
    this.repository.getUserPersonalDetails(userId, callback);
  }

  getUserAcademicDetails(userId, callback) {
    this.repository.getUserAcademicDetails(userId, callback);
  }

  getUserProfessionalDetails(userId, callback) {
    this.repository.getUserProfessionalDetails(userId, callback);
  }
}

module.exports = UsersServices;