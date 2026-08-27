const jwt = require("jsonwebtoken");

class AuthenticationManager {
     static jwtSecreteKey="transflowerLearningtflcomentorproject";
    

    static generateToken(payload) {
        return jwt.sign( payload, AuthenticationManager.jwtSecreteKey, { expiresIn: "1h" });
    }

    static verifyToken(req, res, next) {
        const authHeader = req.headers["authorization"];
        if (!authHeader) {
            return res.status(401).json({
                success: false,
                message: "Access denied. No token provided."
            });
        }

       
        const token = authHeader.split(" ")[1];

        if (!token) {
            return res.status(401).json({
                success: false,
                message: "Invalid token format."
            });
            
        }

        try {
            const decoded = jwt.verify(token, AuthenticationManager.jwtSecreteKey);
            req.user = decoded;
            next();

        } catch (error) {
            return res.status(403).json({
                success: false,
                message: "Invalid or expired token."
            });

        }
    }

}

module.exports = AuthenticationManager;