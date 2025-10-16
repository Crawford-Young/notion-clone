import { create } from "zustand";
import { persist } from "zustand/middleware";

interface User {
  id: string;
  email: string;
  name: string;
}

interface AuthState {
  isAuthenticated: boolean;
  user: User | null;
  token: string | null;
  login: (email: string, password: string) => Promise<void>;
  register: (name: string, email: string, password: string) => Promise<void>;
  logout: () => void;
  setAuth: (user: User, token: string) => void;
}

export const useAuthStore = create<AuthState>()(
  persist(
    (set, get) => ({
      isAuthenticated: false,
      user: null,
      token: null,

      login: async (email: string, password: string) => {
        // TODO: Ticket #5 - Authentication UI
        // Implement actual login API call
        // const response = await api.auth.login({ email, password });
        // set({ isAuthenticated: true, user: response.user, token: response.token });

        // Temporary mock implementation
        console.log("Login attempt:", { email, password });
        set({
          isAuthenticated: true,
          user: { id: "1", email, name: "Test User" },
          token: "mock-token",
        });
      },

      register: async (name: string, email: string, password: string) => {
        // TODO: Ticket #5 - Authentication UI
        // Implement actual registration API call
        // const response = await api.auth.register({ name, email, password });
        // set({ isAuthenticated: true, user: response.user, token: response.token });

        // Temporary mock implementation
        console.log("Register attempt:", { name, email, password });
        set({
          isAuthenticated: true,
          user: { id: "1", email, name },
          token: "mock-token",
        });
      },

      logout: () => {
        set({ isAuthenticated: false, user: null, token: null });
      },

      setAuth: (user: User, token: string) => {
        set({ isAuthenticated: true, user, token });
      },
    }),
    {
      name: "auth-storage",
      partialize: (state) => ({
        isAuthenticated: state.isAuthenticated,
        user: state.user,
        token: state.token,
      }),
    }
  )
);

/* 
TODO: Ticket #5 - Authentication UI
- This file has the basic auth store structure
- Implement actual API calls for login and register
- Add proper error handling
- Add token refresh logic
- Add proper TypeScript types
- Test persistence and state management
*/
