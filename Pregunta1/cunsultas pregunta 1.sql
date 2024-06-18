CREATE TABLE Estudiante (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Edad INT NOT NULL,
    Correo VARCHAR(100) NOT NULL
);

INSERT INTO Estudiante (Nombre, Edad, Correo) VALUES
('Juan Perez', 20, 'juan.perez@example.com'),
('Maria Gomez', 22, 'maria.gomez@example.com'),
('Luis Fernandez', 21, 'luis.fernandez@example.com');

ALTER TABLE Estudiante
ADD COLUMN NumeroMatricula VARCHAR(50); -- Ajusta el tamaño según tus necesidades

INSERT INTO Estudiante (NumeroMatricula, Nombre, Edad, Correo)
VALUES
('2023001', 'Juan Pérez', 20, 'juan.perez@example.com'),
('2023002', 'María González', 22, 'maria.gonzalez@example.com'),
('2023003', 'Pedro García', 21, 'pedro.garcia@example.com'),
('2023004', 'Ana Martínez', 19, 'ana.martinez@example.com'),
('2023005', 'Luis Rodríguez', 23, 'luis.rodriguez@example.com'),
('2023006', 'Laura Sánchez', 20, 'laura.sanchez@example.com'),
('2023007', 'Carlos López', 21, 'carlos.lopez@example.com'),
('2023008', 'Sofía Ramírez', 22, 'sofia.ramirez@example.com'),
('2023009', 'Diego Hernández', 19, 'diego.hernandez@example.com'),
('2023010', 'Valentina Torres', 20, 'valentina.torres@example.com');
