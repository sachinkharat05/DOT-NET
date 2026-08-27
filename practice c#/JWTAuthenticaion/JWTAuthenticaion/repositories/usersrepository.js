class UsersRepository {
  
  constructor(connection) {
    this.connection = connection;
  }


  getUserPersonalDetails(userId, callback) {
    const query = `SELECT p.first_name, p.last_name, p.gender, p.date_of_birth, p.email, p.address, p.pincode,u.contact
      FROM personal_informations p 
      join users u on u.id = p.user_id
      WHERE user_id = ?`;
    this.connection.query(query, [userId], (err, results) => {
      if (err) return callback(err, null);
      const userInformation = results.length > 0 ? results[0] : null;
      callback(null, userInformation);
    });
  }

  getUserAcademicDetails(userId, callback) {
    const query = `SELECT enrollment_year, passing_year, percentage, college_name, stream_name, specialization
      FROM academic_informations
      WHERE user_id = ?`;

    this.connection.query(query, [userId], (err, results) => {
      if (err) return callback(err, null);
      const userInformation = results.length > 0 ? results[0] : null;
      callback(null, userInformation);
    });
  }

  getUserProfessionalDetails(userId, callback) {
    const query = `SELECT company_name, job_title, employment_type, start_date, end_date, is_current_job, experience_years, location, skills
      FROM professional_informations
      WHERE user_id = ?`;

    this.connection.query(query, [userId], (err, results) => {
      if (err) return callback(err, null);
      const userInformation = results.length > 0 ? results[0] : null;
      callback(null, userInformation);
    });
  }
}


module.exports = UsersRepository;
