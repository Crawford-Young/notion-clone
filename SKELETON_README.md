# Notion Clone - Development Skeleton

This project has been reset to a skeleton state to allow for implementation of the development tickets. The skeleton maintains the original project structure but removes the implementation details, replacing them with TODO comments for each ticket.

**Important**: This skeleton preserves the original file structure and only removes implementation details. No new files were created - only existing files were modified to include TODO placeholders.

## Project Structure

### Backend (Clean Architecture + DDD)

The backend maintains the original structure with the following key areas:

```
backend/
├── Backend.Domain/           # Domain layer (skeleton with TODO comments)
│   ├── Aggregates/          # Aggregate roots (Org.cs, Page.cs, Image.cs)
│   ├── Entities/            # Domain entities (User.cs, Member.cs, Block.cs, etc.)
│   ├── ValueObjects/        # Value objects (Email.cs, OrgRole.cs, BlockType.cs, etc.)
│   ├── Events/              # Domain events (IDomainEvent.cs, various event classes)
│   ├── Repositories/        # Repository interfaces (IUserRepository.cs, etc.)
│   └── Common/              # Common domain classes (AggregateRoot.cs)
├── Backend.Application/     # Application layer (skeleton with TODO comments)
│   ├── Services/            # Application services (IPasswordHasher.cs, etc.)
│   └── UseCases/            # Use case handlers (Auth/, Organizations/, Pages/, etc.)
├── Backend.Infrastructure/  # Infrastructure layer (original structure preserved)
└── Backend.Presentation/    # Presentation layer (original structure preserved)
```

**Note**: All existing files have been preserved but their implementation details replaced with TODO comments. The original file structure and naming conventions are maintained.

### Frontend (React + TypeScript)

The frontend maintains the original structure with skeleton implementations:

```
frontend/src/
├── routes/                 # Route components (skeleton with TODO comments)
│   ├── index.tsx          # Home page (Ticket #4)
│   ├── login.tsx          # Login page (Ticket #5)
│   ├── register.tsx       # Registration page (Ticket #5)
│   └── organizations/     # Organization routes (Ticket #10)
├── stores/                # State management (skeleton with TODO comments)
│   └── auth-store.ts      # Authentication store (Ticket #5)
├── components/            # UI components (original shadcn/ui components)
├── features/              # Feature-specific components (original structure)
├── hooks/                 # Custom hooks (original structure)
├── lib/                   # Utilities and API client (original structure)
└── layouts/               # Layout components (original structure)
```

**Note**: Frontend files have been modified to include TODO comments for implementation guidance while preserving the original structure and styling.

## Development Tickets

### Phase 1: Foundation & Setup (Weeks 1-2)

#### Backend Foundation

- **Ticket #1**: Database Schema Setup
- **Ticket #2**: Authentication Infrastructure
- **Ticket #3**: Basic API Structure

#### Frontend Foundation

- **Ticket #4**: Project Setup & Routing
- **Ticket #5**: Authentication UI
- **Ticket #6**: Basic UI Components

### Phase 2: Core Features (Weeks 3-6)

#### Backend Core Features

- **Ticket #7**: Organization Management
- **Ticket #8**: Page Management System
- **Ticket #9**: Block System Implementation

#### Frontend Core Features

- **Ticket #10**: Organization Dashboard
- **Ticket #11**: Page Editor Interface
- **Ticket #12**: Block Editor Implementation

### Phase 3: Advanced Features (Weeks 7-8)

#### Backend Advanced Features

- **Ticket #13**: File Upload System
- **Ticket #14**: Real-time Collaboration
- **Ticket #15**: Invitation System

#### Frontend Advanced Features

- **Ticket #16**: File Upload Interface
- **Ticket #17**: Real-time Collaboration UI
- **Ticket #18**: Invitation Management UI

### Phase 4: Polish & Testing (Weeks 9-10)

#### Testing & Quality Assurance

- **Ticket #19**: Backend Testing
- **Ticket #20**: Frontend Testing
- **Ticket #21**: Performance Optimization
- **Ticket #22**: Frontend Performance
- **Ticket #23**: Security Hardening
- **Ticket #24**: Documentation & Deployment
- **Ticket #25**: Final Integration & Polish

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- Node.js 18+ and Bun
- PostgreSQL
- Redis
- MinIO (for file storage)

### Development Setup

1. **Clone the repository**

   ```bash
   git clone <repository-url>
   cd notion-clone
   ```

2. **Backend Setup**

   ```bash
   cd backend
   dotnet restore
   dotnet build
   ```

3. **Frontend Setup**

   ```bash
   cd frontend
   bun install
   ```

4. **Environment Configuration**

   - Copy `.env.example` to `.env`
   - Configure database connection strings
   - Set JWT secret key
   - Configure CORS settings

5. **Start Development Services**
   ```bash
   docker-compose up -d
   ```

## Implementation Guidelines

### For Each Ticket:

1. **Read the TODO comments** in the relevant files
2. **Follow the acceptance criteria** specified in the ticket
3. **Implement incrementally** - start with basic functionality
4. **Test thoroughly** - write tests for your implementation
5. **Follow Clean Architecture** principles
6. **Use TypeScript** for type safety in frontend
7. **Follow DDD patterns** in backend

### Code Quality Standards:

- **Backend**: Follow C# conventions, use dependency injection, implement proper error handling
- **Frontend**: Use TypeScript, follow React best practices, implement proper error boundaries
- **Testing**: Write unit tests for business logic, integration tests for API endpoints
- **Documentation**: Update README and add inline documentation

### Common Patterns:

- **Repository Pattern**: Use for data access
- **Command/Query Separation**: Use for use cases
- **Domain Events**: Use for cross-cutting concerns
- **Value Objects**: Use for domain concepts
- **Aggregate Roots**: Use for consistency boundaries

## Troubleshooting

### Common Issues:

1. **Database Connection**: Ensure PostgreSQL is running and connection string is correct
2. **CORS Errors**: Check CORS configuration in backend
3. **Authentication**: Verify JWT secret key is set
4. **File Uploads**: Ensure MinIO is running and accessible

### Getting Help:

- Check the TODO comments in each file for specific implementation guidance
- Refer to the original implementation for reference (if needed)
- Use the acceptance criteria as a checklist for completion

## Next Steps

1. Start with **Ticket #1** (Database Schema Setup)
2. Work through tickets in order, as they have dependencies
3. Test each implementation before moving to the next ticket
4. Ask for help if you get stuck on any ticket

Good luck with your development journey! 🚀
