import { TextField } from "@mui/material";
import { useController, UseControllerProps } from "react-hook-form";

interface Props extends UseControllerProps {
    label: string;
    multiline?: boolean;
    rows?: number; 
    type?: string;
}

export default function AppTextInput(props: Props) {
    const {fieldState, field} = useController({...props, defaultValue: ''})

    return (
        <TextField
            multiline={props.multiline} 
            {...props}
            {...field}
            rows={props.rows}
            fullWidth
            variant="outlined"
            type={props.type}
            error={!!fieldState.error}
            helperText={fieldState.error?.message}

        />
    )
}