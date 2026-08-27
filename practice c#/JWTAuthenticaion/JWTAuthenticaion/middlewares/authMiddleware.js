const AuthenticationManager =
require("../helpers/AuthenticationManager");

const authMiddleware = (req,res,next) => {
    AuthenticationManager.verifyToken(req,res,next);
};

module.exports = authMiddleware;